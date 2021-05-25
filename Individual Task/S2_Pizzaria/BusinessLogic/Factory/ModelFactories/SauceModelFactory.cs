using BusinessLogic.Models.IngredientComponents;
using Repository.Entities.Pizza_Components;
using Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Factory.ModelFactories
{
	public static class SauceModelFactory
	{
		public static List<SauceModel> ConvertSauces(List<Sauce> sauces)
		{
			List<SauceModel> models = new List<SauceModel>();

			foreach (var sauce in sauces)
			{
				var model = ConvertSauce(sauce);
				models.Add(model);
			}

			return models;
		}

		public static SauceModel ConvertSauce(Sauce sauce)
		{
			if (sauce == null)
				return null;
			SauceModel model = new SauceModel()
			{
				Id = sauce.Id,
				IsSpicy = sauce.IsSpicy,
				Name = sauce.Name,
				Price = sauce.Price,
			};

			return model;
		}

		public static SauceModel GetSauce(Guid Id)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var sauce = unitOfWork.SauceRepository.GetSauceId(Id);
			var model = ConvertSauce(sauce);
			return model;
		}
	}
}
