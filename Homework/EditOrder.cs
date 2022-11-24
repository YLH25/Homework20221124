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
	public partial class editOrderForm : Form
	{
		private int id;
		public editOrderForm(int id)
		{
			InitializeComponent();
			InitForm();
			
			this.id = id;
		}

		private void editOrderForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}
		

		private void BindData(int id)
		{
			string sql = "SELECT * FROM Orders WHERE Id=@Id";
			var parameters = new SqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				MessageBox.Show("抱歉, 找不到要編輯的記錄");
				this.DialogResult = DialogResult.Abort;

				
				return;
			}

			
			OrderVM model = ToOrderVM(data.Rows[0]);

			
			categoryComboBox.SelectedItem = ((List<FoodCategoryVM>)categoryComboBox.DataSource)
												.FirstOrDefault(x => x.Id == model.FoodCategoryId);

			NameTextBox.Text = model.OrderName;
			amountTextBox.Text = model.Amount.ToString();

		}
		private OrderVM ToOrderVM(DataRow row)
		{
			return new OrderVM
			{
				Id = row.Field<int>("Id"),
				OrderName = row.Field<string>("OrderName"),
				FoodCategoryId = row.Field<int>("FoodCategoryId"),
				Amount = row.Field<int>("Amount")
			};
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




		private void updateButton_Click(object sender, EventArgs e)
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
				string sql = @"UPDATE Orders
			SET OrderName=@OrderName, FoodCategoryId=@FoodCategoryId, Amount = @Amount
			WHERE Id=@Id";

				var parameters = new SqlParameterBuilder()
					.AddInt("Id", this.id)
					.AddNVarchar("OrderName", 50, model.OrderName)
					.AddInt("FoodCategoryId", model.FoodCategoryId)
					.AddInt("Amount", model.Amount)
					.Build();

				new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

				this.DialogResult = DialogResult.OK;
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (MessageBox
				.Show("您真的要刪除嗎?",
						"刪除記錄",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			string sql = @"DELETE FROM Orders WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddInt("Id", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;

		}
	}
}
