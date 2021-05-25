using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_Layer.Models.IngredientComponents
{
	public class PizzaModel
	{
		public List<IngredientModel> Ingredients { get; set; }
		public BottomModel Bottom { get; set; }
	}
}
