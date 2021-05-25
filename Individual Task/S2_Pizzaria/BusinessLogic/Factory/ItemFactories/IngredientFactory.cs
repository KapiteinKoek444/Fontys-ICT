using BusinessLogic.Models.IngredientComponents;
using Repository.Entities.Pizza_Components.IngredientTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Factory
{
	public static class IngredientFactory
	{
		public static List<Ingredients> ConvertIngredientModels(List<IngredientModel> models)
		{
			List<Ingredients> ingredients = new List<Ingredients>();

			foreach(var model in models)
			{
				var ing = ConvertIngredientModel(model);
				ingredients.Add(ing);
			}

			return ingredients;
		}

		public static Ingredients ConvertIngredientModel(IngredientModel model)
		{
			if (model == null)
				return null;

			Ingredients ingredient = new Ingredients
			{
				Id = model.Id,
				Name = model.Name,
				SpicyGrade = model.SpicyGrade,
				Price = model.Price,
				ContainsLactose = model.ContainsLactose,
				IsHalal = model.IsHalal,
				IsVegan = model.IsVegan,
				IsVegetarian = model.IsVegetarian,
			};

			return ingredient;
		}
	}
}
