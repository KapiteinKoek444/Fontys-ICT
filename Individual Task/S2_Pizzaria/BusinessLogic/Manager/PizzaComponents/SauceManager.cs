using BusinessLogic.Factory.ItemFactories;
using BusinessLogic.Factory.ModelFactories;
using BusinessLogic.Models.IngredientComponents;
using Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Manager.PizzaComponents
{
	public static class SauceManager
	{
		public static void RemoveSauce(SauceModel model)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var sauce = SauceFactory.ConvertSauce(model);
			unitOfWork.SauceRepository.RemoveSauce(sauce.Id);
		}

		public static List<SauceModel> GetAllSauces()
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var sauces = unitOfWork.SauceRepository.GetAllSauce();
			var models = SauceModelFactory.ConvertSauces(sauces);
			return models;
		}

		public static void AddSauces(List<SauceModel> models)
		{
			foreach (var model in models)
				AddSauce(model);
		}

		public static void AddSauce(SauceModel model)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			model.Id = Guid.NewGuid();
			var sauce = SauceFactory.ConvertSauce(model);
			unitOfWork.SauceRepository.AddSauce(sauce);
		}
	}
}
