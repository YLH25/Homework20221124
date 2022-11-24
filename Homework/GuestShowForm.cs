using Homework.model.VM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Homework.model.Utility.SqlDbHelper;
using static Homework.model.Utility;

namespace Homework
{
	public partial class GuestShowForm : Form
	{
		private OrderIndexVM[] orders = null;
		public GuestShowForm()
		{
			InitializeComponent();
			InitForm();


			DisplayOrders();
		}
		private void InitForm()
		{

			categoryIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			var sql = "SELECT * FROM FoodCategories F ORDER BY Price";
			var dbHelper = new SqlDbHelper("default");

			List<FoodCategoryVM> categories = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToCategoryVM(row))
				.Prepend(new FoodCategoryVM { Id = 0, CategoryName = "全部" })
				.ToList();

			this.categoryIdComboBox.DataSource = categories;

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


		private void DisplayOrders()
		{
			string sql = @"SELECT O.Id, O.OrderName, F.CategoryName, O.Amount FROM Orders O
			JOIN FoodCategories F ON O.FoodCategoryId = F.Id";
			SqlParameter[] parameters = new SqlParameter[] { };
			int foodcategoryid = ((FoodCategoryVM)categoryIdComboBox.SelectedItem).Id;
			if (foodcategoryid > 0)
			{
				sql += " WHERE FoodCategoryId=@FoodCategoryId";
				parameters = new SqlParameterBuilder()
				.AddInt("FoodCategoryId", foodcategoryid)
					.Build();
			}
			sql += " ORDER BY O.Id";
			var dbHelper = new SqlDbHelper("default");

			orders = dbHelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row))
				.ToArray();

			BindData(orders);
		}
		private void BindData(OrderIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}
		private OrderIndexVM ParseToIndexVM(DataRow row)
		{
			return new OrderIndexVM
			{
				Id = row.Field<int>("Id"),
				OrderName = row.Field<string>("OrderName"),
				FoodCategory = row.Field<string>("CategoryName"),
				Amount = row.Field<int>("Amount"),
			};
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			DisplayOrders();
		}
		private void addButton_Click(object sender, EventArgs e)
		{
			var frm = new addOrderFrom();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayOrders();
			}
		}

		private void refreshButton_Click(object sender, EventArgs e)
		{
			InitForm();


			DisplayOrders();
		}

		private void 後臺維護ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm=new LoginForm();
			frm.Show();
		}

		private void Menubutton_Click(object sender, EventArgs e)
		{
			var frm = new MenuForm();
			frm.Show();
		}
	}
}
