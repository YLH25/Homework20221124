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
	public partial class MenuForm : Form
	{
		DataTable categories;
		public MenuForm()
		{
			InitializeComponent();
			DisplayFoodCatetories();
		}
		private void DisplayFoodCatetories()
		{
			string sql = @"SELECT Id,categoryName,Price FROM FoodCategories ORDER BY Id";

			categories = new SqlDbHelper("default").Select(sql, null);

			BindData(categories);
		}

		private void BindData(DataTable model)
		{
			dataGridView1.DataSource = model;
		}
	}
}
