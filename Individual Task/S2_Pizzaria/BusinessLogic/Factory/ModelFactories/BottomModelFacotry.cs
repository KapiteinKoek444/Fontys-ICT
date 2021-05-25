using BusinessLogic.Models.IngredientComponents;
using Repository.Entities.Pizza_Components;
using Repository.Entities.Pizza_Components.BottomType;
using Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Factory.ModelFactories
{
	public static class BottomModelFacotry
	{
		public static List<BottomModel> ConvertBottoms(List<Bottom> bottoms)
		{
			List<BottomModel> models = new List<BottomModel>();

			foreach (var bot in bottoms)
			{
				var model = ConvertBottom(bot);
				models.Add(model);
			}

			return models;
		}

		public static BottomModel ConvertBottom(Bottom bottom)
		{
			if (bottom == null)
				return null;
			var sauceModel = SauceModelFactory.GetSauce(bottom.SauceId);

			BottomModel model = new BottomModel()
			{
				Id = bottom.Id,
				Sauce = sauceModel,
				Price = bottom.Price,
				Surface = bottom.Surface,
				Thick = bottom.Thick,
				Name = bottom.Name,
			};

			return model;
		}

		public static BottomModel GetBottomModel(Guid Id)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var bottom = unitOfWork.BottomRepository.GetBottom(Id);
			var model = ConvertBottom(bottom);
			return model;
		}
	}
}
