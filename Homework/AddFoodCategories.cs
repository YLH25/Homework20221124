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
using Homework.model;

namespace Homework
{
	public partial class addFoodCategoriesFrom : Form
	{
		public addFoodCategoriesFrom()
		{
			InitializeComponent();
		}
		private void saveButton_Click(object sender, EventArgs e)
		{
			string categoryName = categoryNameTextBox.Text;
			int Price = priceTextBox.Text.ToInt(-1);
			if (string.IsNullOrEmpty(categoryName))
			{
				MessageBox.Show("必須填入餐點名稱");
				return;
			}
			if (Price <= 0 )
			{
				MessageBox.Show("必須填入正整數金額");
				return ;
			}
			
			else
			{
				string sql = @"INSERT INTO FoodCategories
		(CategoryName, Price)
		VALUES
		(@CategoryName, @Price)";

				var parameters = new SqlParameterBuilder()
					.AddNVarchar("CategoryName", 50, categoryName)
					.AddInt("Price", Price)
					.Build();
				new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
				this.DialogResult = DialogResult.OK;
			}
		}
	}
}
