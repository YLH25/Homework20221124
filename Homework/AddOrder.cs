using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Homework.model.Utility.SqlDbHelper;
using static Homework.model.Utility;
using Homework.model.VM;
using Homework.model;

namespace Homework
{
	public partial class addOrderFrom : Form
	{
		public addOrderFrom()
		{
			InitializeComponent();
			InitForm();
		}
		private void InitForm()
		{
			
			categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			var sql = "SELECT * FROM FoodCategories ORDER BY Price";
			var dbHelper = new SqlDbHelper("default");

			List<FoodCategoryVM> categories = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToCategoryVM(row))
				
				.ToList();

			this.categoryComboBox.DataSource = categories;

		}

		private FoodCategoryVM ToCategoryVM(DataRow row)
		{
			return new FoodCategoryVM
			{
				Id = row.Field<int>("Id"),
				CategoryName = row.Field<string>("CategoryName"),
				Price = row.Field<int>("Price")
			};
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			
			int foodcategoryid = ((FoodCategoryVM)this.categoryComboBox.SelectedItem).Id;

			string name = NameTextBox.Text;
			int amount = amountTextBox.Text.ToInt(-1);
			if (string.IsNullOrEmpty(name))
			{
				MessageBox.Show("必須填寫誰訂餐人");
			
			}

			else if (amount <= 0)
			{
				MessageBox.Show("必須填入正整數數量");
			}
			else
			{

				OrderVM model = new OrderVM
				{
					FoodCategoryId = foodcategoryid,
					OrderName = name,
					Amount = amount,
				};


				string sql = @"INSERT INTO Orders
				(OrderName,FoodCategoryId, Amount)
				VALUES
				(@OrderName,@FoodCategoryId, @Amount)";

				var parameters = new SqlParameterBuilder()
					.AddNVarchar("OrderName", 50, model.OrderName)
					.AddInt("FoodCategoryId", model.FoodCategoryId)
					.AddInt("Amount", model.Amount)
					.Build();

				new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

				this.DialogResult = DialogResult.OK;
			}
			
		}
	}
}
