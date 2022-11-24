using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.model.VM
{ 	
	public class OrderIndexVM
	{
		public int Id { get; set; }
		public string OrderName { get; set; }
		public string FoodCategory { get; set; }
		public int Amount { get; set; }
	}

		/// <summary>
		/// 供CreateProductForm, EditProductForm使用
		/// </summary>
	public class OrderVM
	{
		public int Id { get; set; }
		public string OrderName { get; set; }
		public int FoodCategoryId { get; set; }//FoodCategory
		public int Amount { get; set; }
	}
	public class FoodCategoryVM
	{
		public int Id { get; set; }
		public string CategoryName { get; set; }
		public int Price { get; set; }
	}
}
