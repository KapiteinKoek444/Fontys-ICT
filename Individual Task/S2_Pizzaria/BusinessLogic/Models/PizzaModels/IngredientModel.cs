using BusinessLogic.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models.IngredientComponents
{
	public class IngredientModel : EntityModelBase
	{
		public Guid PizzaIngredientID { get; set; }
		public string Name { get; set; }
		public int Price { get; set; }
		public int SpicyGrade { get; set; }
		public bool? IsVegetarian { get; set; }
		public bool? IsVegan { get; set; }
		public bool? IsHalal { get; set; }
		public bool? ContainsLactose { get; set; }
	}
}
