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
using static Homework.model.Utility.SqlDbHelper;

namespace Homework
{
	public partial class foodCategoriesForm : Form
	{
		DataTable categories;
		public foodCategoriesForm()
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

		private void addnewButton_Click(object sender, EventArgs e)
		{
			var frm = new addFoodCategoriesFrom();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayFoodCatetories();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;
			if (rowIndx < 0) return;
			DataRow row = this.categories.Rows[rowIndx];
			int id = row.Field<int>("Id");
			var frm = new editFoodCategoriesForm(id);
			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayFoodCatetories();
			}
		}
		
	}

}
