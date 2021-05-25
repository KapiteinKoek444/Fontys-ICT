using BusinessLogic.Models.IngredientComponents;
using Repository.Entities.Pizza_Components.IngredientTypes;
using Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Factory
{
	public static class IngredientModelFactory
	{
		public static List<IngredientModel> ConvertIngredients(List<Ingredients> ingredients)
		{
			List<IngredientModel> models = new List<IngredientModel>();

			foreach (var ing in ingredients)
			{
				var model = ConvertIngredient(ing);
				models.Add(model);
			}

			return models;
		}

		public static IngredientModel ConvertIngredient(Ingredients ingredient)
		{
			if (ingredient == null)
				return null;
			IngredientModel model = new IngredientModel()
			{
				Id = ingredient.Id,
				Name = ingredient.Name,
				SpicyGrade = ingredient.SpicyGrade,
				Price = ingredient.Price,
				ContainsLactose = ingredient.ContainsLactose,
				IsHalal = ingredient.IsHalal,
				IsVegan = ingredient.IsVegan,
				IsVegetarian = ingredient.IsVegetarian,
			};

			return model;
		}

		public static IngredientModel GetIngredientModel(Guid Id)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var ingredient = unitOfWork.IngredientRepository.GetIngredient(Id);
			var model = ConvertIngredient(ingredient);
			return model;
		}
	}
}
