using BusinessLogic.Factory.ItemFactories;
using BusinessLogic.Factory.ModelFactories;
using BusinessLogic.Models.IngredientComponents;
using Repository.Entities.Pizza_Components.BottomType;
using Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Manager.PizzaComponents
{
	public static class BottomManager
	{
		public static void RemoveBottom(BottomModel model)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var bottom = BottomFactory.ConvertBottom(model);
			unitOfWork.BottomRepository.RemoveBottom(bottom.Id);
		}

		public static List<BottomModel> GetAllBottoms()
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var bottoms = unitOfWork.BottomRepository.GetAllBottoms();
			var models = BottomModelFacotry.ConvertBottoms(bottoms);
			return models;
		}

		public static List<BottomModel> AddBottoms(List<BottomModel> models)
		{
			foreach (var model in models)
			{
				AddBottom(model);
			}

			return models;
		}

		public static BottomModel AddBottom(BottomModel model)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			model.Id = Guid.NewGuid();
			unitOfWork.BottomRepository.AddBottom(BottomFactory.ConvertBottom(model));
			return model;
		}

		public static BottomModel ApplySauce(BottomModel model, SauceModel smodel)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			model.Sauce = smodel;
			var bottom = BottomFactory.ConvertBottom(model);
			unitOfWork.BottomRepository.AddOrUpdate(bottom);
			return model;
		}
	}
}
