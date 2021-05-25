using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_Layer.Models.IngredientComponents
{
	public class IngredientModel
	{
		public string Name { get; set; }
		public int Price { get; set; }
		public int SpicyGrade { get; set; }
		public int Quantity { get; set; }
		public bool? IsVegetarian { get; set; }
		public bool? IsVegan { get; set; }
		public bool? IsHalal { get; set; }
		public bool? ContainsLactose { get; set; }
	}
}
