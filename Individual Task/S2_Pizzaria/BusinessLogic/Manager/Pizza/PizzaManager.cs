using BusinessLogic.Factory;
using BusinessLogic.Factory.ItemFactories;
using BusinessLogic.Factory.ModelFactories;
using BusinessLogic.Models;
using BusinessLogic.Models.IngredientComponents;
using BusinessLogic.Models.ViewModels;
using Repository.Entities.Connections;
using Repository.Entities.Pizza_Components.IngredientTypes;
using Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Manager.Pizza
{
	public static class PizzaManager
	{
		public static void RemovePizza(PizzaModel model)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var pizza = PizzaFactory.ConvertPizzaModel(model);
			unitOfWork.PizzaRepository.RemovePizza(pizza.Id);
		}

		public static List<PizzaModel> AddPizzas(List<PizzaModel> models)
		{
			foreach (var model in models)
			{
				AddPizza(model);
			}

			return models;
		}

		public static PizzaModel AssignIngredients(PizzaModel model, List<IngredientModel> ingredients)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			foreach (var ing in ingredients)
			{
				PizzaIngredientModel pizIng = new PizzaIngredientModel
				{
					Id = new Guid(),
					Ingredient = ing,
					PizzaId = model.Id
				};
				unitOfWork.PizzaIngredientRepository.AddPizza_Ingredients(PizzaIngredientFactory.ConvertPizzaIngredientModel(pizIng));
				model.PizzaIngredients.Add(pizIng);
			}
			unitOfWork.PizzaRepository.UpdatePizza(PizzaFactory.ConvertPizzaModel(model));
			return model;
		}

		public static PizzaModel AssignBottomToPizza(PizzaModel model, BottomModel bottom, SauceModel sauce)
		{
			if (model == null || bottom == null || sauce == null)
				return null;

			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();

			bottom.Sauce = sauce;
			model.Bottom = bottom;

			unitOfWork.PizzaRepository.UpdatePizza(PizzaFactory.ConvertPizzaModel(model));
			return model;
		}

		public static List<PizzaModel> getAllPizzas()
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var pizzas = unitOfWork.PizzaRepository.GetAllPizza().ToList();
			var models = PizzaModelFactory.ConvertPizzas(pizzas);
			return models;
		}

		public static PizzaModel GetPizza(Guid id)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var pizzas = unitOfWork.PizzaRepository.GetPizzaId(id);
			var model = PizzaModelFactory.ConvertPizza(pizzas);
			return model;
		}

		public static PizzaModel AddIngredientToPizza(PizzaModel pizza, IngredientModel ingredient)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			PizzaIngredientModel pizIngModel = new PizzaIngredientModel();
			pizIngModel.Ingredient = ingredient;
			pizIngModel.PizzaId = pizza.Id;
			pizza.PizzaIngredients.Add(pizIngModel);
			var _object = PizzaFactory.ConvertPizzaModel(pizza);
			unitOfWork.PizzaRepository.UpdatePizza(_object);
			return pizza;
		}

		public static OrderViewModel OrderPizza(Guid userId, Guid pizzaId, Guid bottomId, Guid sauceId, List<Guid> ingredientId)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			
			OrderRule orderrule = new OrderRule();
			var order = unitOfWork.OrderRepository.GetAllOrders().Where(x => x.UserId == userId).FirstOrDefault();
			var piz = unitOfWork.PizzaRepository.GetPizzaId(pizzaId);
			var bot = unitOfWork.BottomRepository.GetBottom(bottomId);
			var sc = unitOfWork.SauceRepository.GetSauceId(sauceId);

			if(order == null)
			{
				order = new Order();
				order.Id = Guid.NewGuid();
				order.OrderRule = new List<OrderRule>();
			}

			List<Ingredients> _Ing = new List<Ingredients>();
			foreach(var ing in ingredientId)
			{
				var ingr = unitOfWork.IngredientRepository.GetAllIngredients().Where(x => x.Id == ing).FirstOrDefault();
				_Ing.Add(ingr);
			}
			
			foreach(var ing in _Ing)
			{
				Pizza_Ingredient pizza_Ingredient = new Pizza_Ingredient();
				pizza_Ingredient.Id = Guid.NewGuid();
				pizza_Ingredient.IngriedientId = ing.Id;
				pizza_Ingredient.PizzaIngredient_Id = pizzaId;
				unitOfWork.PizzaIngredientRepository.AddPizza_Ingredients(pizza_Ingredient);
				piz.PizzaIngredient.Add(pizza_Ingredient);
			}
			bot.SauceId = sc.Id;
			piz.BottomId = bot.Id;
			piz.OrderRuleId = orderrule.Id;

			orderrule.Id = Guid.NewGuid();
			orderrule.OrderId = order.Id;
			orderrule.PizzaId = piz.Id;
			
			order.OrderRule.Add(orderrule);			

			unitOfWork.PizzaRepository.UpdatePizza(piz);
			unitOfWork.OrderRepository.AddOrUpdate(order);
			unitOfWork.OrderRuleRepository.AddOrUpdate(orderrule);
			var pizza = PizzaModelFactory.ConvertPizza(piz);
			var orderViewModel = new OrderViewModel()
			{
				pizza = pizza,
				bottom = BottomModelFacotry.ConvertBottom(bot),
				sauce = SauceModelFactory.ConvertSauce(sc),
				ingredients = IngredientModelFactory.ConvertIngredients(_Ing)
			};
			return orderViewModel;
		}

		public static PizzaModel AddPizza(PizzaModel model)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			model.Id = Guid.NewGuid();
			var pizza = PizzaFactory.ConvertPizzaModel(model);
			unitOfWork.PizzaRepository.AddPizza(pizza);
			return model;
		}

		public static void OrderOrder(OrderViewModel model)
		{
			var pizza = PizzaFactory.ConvertPizzaModel(model.pizza);
			var bottom = BottomFactory.ConvertBottom(model.bottom);
			var sauce = SauceFactory.ConvertSauce(model.sauce);
			var ingredients = IngredientFactory.ConvertIngredientModels(model.ingredients);

			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			unitOfWork.BottomRepository.RemoveBottom(bottom.Id);
			unitOfWork.PizzaRepository.RemovePizza(pizza.Id);
			unitOfWork.SauceRepository.RemoveSauce(sauce.Id);
			
			foreach (var ing in ingredients)
			{
				unitOfWork.IngredientRepository.RemoveIngredient(ing.Id);
			}
		}
	}
}
