using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer.Entities.Pizza_Components.IngredientTypes;
using Data_Layer.Entities.Pizza_Components.BottomType;

namespace Data_Layer.Entities.Pizza_Components
{
	public class Pizza
	{
		public List<Ingredients> Ingredients { get; set; }
		public Bottom Bottom { get; set; }

		public Pizza(List<Ingredients> ingredients, Bottom bottom)
		{
			Ingredients = ingredients;
			Bottom = bottom;
		}
	}
}
