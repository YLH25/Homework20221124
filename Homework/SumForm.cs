using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Homework.model.Utility;

namespace Homework
{
	public partial class SumForm : Form
	{
		DataTable categories;
		public SumForm()
		{
			InitializeComponent();
			DisplayFoodCatetories();
			DisplayFoodCatetories2();
		}
		private void DisplayFoodCatetories()
		{
			string sql = @"select F.CategoryName [餐點名稱],sum(Amount) [數量] from Orders O 
			join FoodCategories F on F.ID = O.FoodCategoryId group by o.FoodCategoryId,F.CategoryName";

			categories = new SqlDbHelper("default").Select(sql, null);

			BindData(categories);
		}

		private void BindData(DataTable model)
		{
			dataGridView1.DataSource = model;
		}

		private void sumButton_Click(object sender, EventArgs e)
		{
			string sql = "select sum(Amount* Price) as sum from Orders O join FoodCategories F on F.ID = O.FoodCategoryId";
			var sum = new SqlDbHelper("default").Select(sql, null);
			MessageBox.Show($"總計{sum.Rows[0].Field<int>("sum")}元");
		}

		private void DisplayFoodCatetories2()
		{
			string sql = @"SELECT OrderName[訂餐人],Sum(Amount*Price) [應付金額] FROM Orders O 
							JOIN FoodCategories F ON O.FoodCategoryId=F.Id group by OrderName";

			categories = new SqlDbHelper("default").Select(sql, null);

			BindData2(categories);
		}

		private void BindData2(DataTable model2)
		{
			dataGridView2.DataSource = model2;
		}
	}
}
