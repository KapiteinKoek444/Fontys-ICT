using BusinessLogic.Factory.ItemFactories;
using BusinessLogic.Models.IngredientComponents;
using Repository.Entities.Connections;
using Repository.Entities.Pizza_Components;
using Repository.Entities.Pizza_Components.BottomType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Factory
{
	public static class PizzaFactory
	{
		public static List<Pizza> ConvertPizzaModels(List<PizzaModel> models)
		{
			List<Pizza> pizzas = new List<Pizza>();

			foreach (var model in models)
			{
				var pizza = ConvertPizzaModel(model);
				pizzas.Add(pizza);
			}

			return pizzas;
		}

		public static Pizza ConvertPizzaModel(PizzaModel model)
		{
			List<Pizza_Ingredient> pizzaIngredient = new List<Pizza_Ingredient>();
			Bottom bottom = new Bottom();

			if (model == null)
				return null;

			if (model.PizzaIngredients != null)
				pizzaIngredient = PizzaIngredientFactory.ConvertPizzaIngredientModels(model.PizzaIngredients);

			if (model.Bottom != null)
				bottom = BottomFactory.ConvertBottom(model.Bottom);

			Pizza pizza = new Pizza
			{
				Id = model.Id,
				Name = model.Name,
				BottomId = bottom.Id,
				Price = model.Price,
				OrderRuleId = model.OrderRuleId,
				PizzaIngredient = pizzaIngredient
			};

			return pizza;
		}
	}
}
