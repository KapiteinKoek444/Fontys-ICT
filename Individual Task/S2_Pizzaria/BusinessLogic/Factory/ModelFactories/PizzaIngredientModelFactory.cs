using BusinessLogic.Models;
using Repository.Entities.Connections;
using Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Factory.ModelFactories
{
	public static class PizzaIngredientModelFactory
	{
		public static List<PizzaIngredientModel> ConvertPizzaIngredients(List<Pizza_Ingredient> pizzaIngredients)
		{
			List<PizzaIngredientModel> models = new List<PizzaIngredientModel>();

			foreach (var pizIng in pizzaIngredients)
			{
				var model = ConvertPizzaIngredient(pizIng);
				models.Add(model);
			}

			return models;
		}

		public static PizzaIngredientModel ConvertPizzaIngredient(Pizza_Ingredient pizIng)
		{
			if (pizIng == null)
				return null;
			var ingredient = IngredientModelFactory.GetIngredientModel(pizIng.IngriedientId);

			PizzaIngredientModel model = new PizzaIngredientModel
			{
				Id = pizIng.Id,
				PizzaId = pizIng.PizzaIngredient_Id,
				Ingredient = ingredient
			};

			return model;
		}

		public static PizzaIngredientModel GetPizzaIngredientModel(Guid Id)
		{
			UnitOfWorkRepository unitOfWorkRepository = new UnitOfWorkRepository();
			var pizIng = unitOfWorkRepository.PizzaIngredientRepository.GetPizza_Ingredient(Id);
			var model = ConvertPizzaIngredient(pizIng);
			return model;
		}
	}
}
