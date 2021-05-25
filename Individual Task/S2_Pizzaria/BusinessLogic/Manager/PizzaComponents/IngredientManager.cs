using BusinessLogic.Factory;
using BusinessLogic.Models.IngredientComponents;
using Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Manager.PizzaComponents
{
	public static class IngredientManager
	{
		public static void RemoveIngredient(IngredientModel model)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var ingredient = IngredientFactory.ConvertIngredientModel(model);
			unitOfWork.IngredientRepository.RemoveIngredient(ingredient.Id);
		}

		public static List<IngredientModel> AddIngredients(List<IngredientModel> models)
		{
			foreach (var model in models)
			{
				AddIngredient(model);
			}

			return models;
		}

		public static IngredientModel AddIngredient(IngredientModel model)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			model.Id = Guid.NewGuid(); 
			var ingredient = IngredientFactory.ConvertIngredientModel(model);
			unitOfWork.IngredientRepository.AddIngredient(ingredient);
			return model;
		}

		public static List<IngredientModel> GetIngredients()
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var ingredients = unitOfWork.IngredientRepository.GetAllIngredients();
			var models = IngredientModelFactory.ConvertIngredients(ingredients);
			return models;
		}

		public static IngredientModel GetIngredient(Guid Id)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var ingredient = unitOfWork.IngredientRepository.GetIngredient(Id);
			var model = IngredientModelFactory.ConvertIngredient(ingredient);
			return model;
		}
	}
}
