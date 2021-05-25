using BusinessLogic.Factory.ModelFactories;
using BusinessLogic.Models;
using BusinessLogic.Models.IngredientComponents;
using Repository.Entities.Pizza_Components;
using Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace BusinessLogic.Factory
{
	public static class PizzaModelFactory
	{
		public static List<PizzaModel> ConvertPizzas(List<Pizza> pizzas)
		{
			List<PizzaModel> Models = new List<PizzaModel>();
			List<IngredientModel> ingredients = new List<IngredientModel>();

			foreach (var pizza in pizzas)
			{
				var model = ConvertPizza(pizza);
				Models.Add(model);
			}

			return Models;
		}

		public static PizzaModel ConvertPizza(Pizza pizza)
		{
			if (pizza == null)
				return null;
			var bottomModel = BottomModelFacotry.GetBottomModel(pizza.BottomId);
			var pizzaIngredientModel = PizzaIngredientModelFactory.ConvertPizzaIngredients(pizza.PizzaIngredient);

			PizzaModel pizzaModel = new PizzaModel()
			{
				Id = pizza.Id,
				Name = pizza.Name,
				Price = pizza.Price,
				OrderRuleId = pizza.OrderRuleId,
				Bottom = bottomModel,
				PizzaIngredients = pizzaIngredientModel
			};

			return pizzaModel;
		}

		public static PizzaModel GetPizzaModel(Guid Id)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var pizza = unitOfWork.PizzaRepository.GetPizzaId(Id);
			var model = ConvertPizza(pizza);
			return model;
		}
	}
}
