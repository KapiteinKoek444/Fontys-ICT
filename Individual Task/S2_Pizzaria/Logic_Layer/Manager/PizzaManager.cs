using Data_Layer.Entities.Pizza_Components;
using Data_Layer.Entities.Pizza_Components.IngredientTypes;
using Data_Layer.TemporaryData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_Layer.Manager
{
	public class PizzaManager
	{
		public TemporaryPizzaBuilder pizzaBuilder = new TemporaryPizzaBuilder();
		public List<Pizza> Pizzas { get; set; }
		public List<Ingredients> Ingrdients { get; set; }

		public PizzaManager()
		{
			Pizzas = pizzaBuilder.pizzas;
			Ingrdients = pizzaBuilder.ingredients;
		}

		public List<Pizza> GetAllPizzas()
		{
			return Pizzas;
		}

		public Pizza GetPizza(int Id)
		{
			return Pizzas[Id];
		}

		public Pizza CreatePizza(Pizza pizza)
		{
			Pizzas.Add(pizza);
			return pizza;
		}

		public Pizza RemovePizza(int Id)
		{
			Pizzas.RemoveAt(Id);
			return Pizzas[Id];
		}
	}
}
