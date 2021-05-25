using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Entities.Pizza_Components.IngredientTypes
{
	public class Ingredients
	{
		public string Name { get; set; }
		public int Price { get; set; }
		public int SpicyGrade { get; set; }
		public int Quantity { get; set; }
		public bool? IsVegetarian { get; set; }
		public bool? IsVegan { get; set; }
		public bool? IsHalal { get; set; }
		public bool? ContainsLactose { get; set; }

		public Ingredients(string name, int price, int spicyGrade, int quantity, bool isVegetarian, bool isVegan, bool isHalal, bool containsLactose)
		{
			Name = name;
			Price = price;
			SpicyGrade = spicyGrade;
			Quantity = quantity;
			IsVegetarian = isVegetarian;
			IsVegan = IsVegan;
			IsHalal = isHalal;
			ContainsLactose = containsLactose;
		}
	}
}
