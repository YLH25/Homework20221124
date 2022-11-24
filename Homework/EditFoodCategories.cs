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
	public partial class editFoodCategoriesForm : Form
	{
		private int id;
		public editFoodCategoriesForm(int id)
		{
			InitializeComponent();
			this.id = id;
			BindData(id);
		}
		private void BindData(int id)
		{
			string sql = "SELECT * FROM FoodCategories WHERE Id=@Id";
			var parameters = new SqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				MessageBox.Show("抱歉, 找不到要編輯的記錄");
				this.DialogResult = DialogResult.Abort;

				this.Close();
				return;
			}
			DataRow row = data.Rows[0];
			categoryNameTextBox.Text = row.Field<string>("CategoryName");
			PriceTextBox.Text = row.Field<int>("Price").ToString();
		}
		private void updateButton_Click(object sender, EventArgs e)
		{
			string categoryName = categoryNameTextBox.Text;

			int Price = PriceTextBox.Text.ToInt(-1);
			if (string.IsNullOrEmpty(categoryName))
			{
				MessageBox.Show("必須填入餐點名稱");
				return;
			}
			if (Price <= 0) 
			{ 
				MessageBox.Show("必須填入正整數金額");
				return ;
			}
			
			else
			{
				string sql = @"UPDATE FoodCategories
						SET CategoryName=@CategoryName, Price=@Price
						WHERE Id=@Id";

				var parameters = new SqlParameterBuilder()
					.AddNVarchar("CategoryName", 50, categoryName)
					.AddInt("Price", Price)
					.AddInt("Id", this.id)
					.Build();

				new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

				this.DialogResult = DialogResult.OK;
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox
					.Show("您真的要刪除嗎?",
							"刪除記錄",
							MessageBoxButtons.YesNo,
							MessageBoxIcon.Question) != DialogResult.Yes)
				{
					return;
				}

				string sql = @"DELETE FROM FoodCategories WHERE Id=@Id";

				var parameters = new SqlParameterBuilder()
					.AddInt("Id", this.id)
					.Build();

				new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

				this.DialogResult = DialogResult.OK;
			}
			catch 
			{
				MessageBox.Show("無法刪除，請檢查資料是否衝突。");
			}
		}
	}
}
