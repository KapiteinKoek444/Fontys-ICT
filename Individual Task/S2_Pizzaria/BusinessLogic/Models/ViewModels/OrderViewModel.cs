using BusinessLogic.Models.IngredientComponents;
using Repository.Entities.Pizza_Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models.ViewModels
{
	public class OrderViewModel
	{
		public BottomModel bottom { get; set; }
		public PizzaModel pizza { get; set; }
		public SauceModel sauce { get; set; }
		public List<IngredientModel> ingredients { get; set; }
		public double TotalPrice { get; set; }
	}
}

