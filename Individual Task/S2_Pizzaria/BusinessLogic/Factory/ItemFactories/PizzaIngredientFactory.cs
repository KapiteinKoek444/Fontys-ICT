using BusinessLogic.Models;
using Repository.Entities.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Factory.ItemFactories
{
	public static class PizzaIngredientFactory
	{
		public static List<Pizza_Ingredient> ConvertPizzaIngredientModels(List<PizzaIngredientModel> models)
		{
			List<Pizza_Ingredient> pizIngs = new List<Pizza_Ingredient>();
			foreach (var model in models)
			{
				var pizIng = ConvertPizzaIngredientModel(model);
				pizIngs.Add(pizIng);
			}

			return pizIngs;
		}

		public static Pizza_Ingredient ConvertPizzaIngredientModel(PizzaIngredientModel model)
		{
			if (model == null)
				return null;

			Pizza_Ingredient pizINg = new Pizza_Ingredient()
			{
				Id = model.Id,
				PizzaIngredient_Id = model.PizzaId,
				IngriedientId = model.Ingredient.Id
			};

			return pizINg;
		}
	}
}
