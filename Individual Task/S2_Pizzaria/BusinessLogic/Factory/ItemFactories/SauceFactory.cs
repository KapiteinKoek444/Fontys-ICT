using BusinessLogic.Models.IngredientComponents;
using Repository.Entities.Pizza_Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Factory.ItemFactories
{
	public static class SauceFactory
	{
		public static List<Sauce> ConvertSauces(List<SauceModel> models)
		{
			List<Sauce> sauces = new List<Sauce>();

			foreach(var model in models)
			{
				var sauce = ConvertSauce(model);
				sauces.Add(sauce);
			}

			return sauces;
		}

		public static Sauce ConvertSauce(SauceModel model)
		{
			if (model == null)
				return null;

			Sauce sauce = new Sauce() {
				Id = model.Id,
				IsSpicy = model.IsSpicy,
				Name = model.Name,
				Price = model.Price,
			};

			return sauce;
		}
	}
}
