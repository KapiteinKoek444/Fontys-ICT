using Data_Layer.Entities.Pizza_Components;
using Data_Layer.Entities.Pizza_Components.IngredientTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Layer.TemporaryData
{
	public class TemporaryPizzaBuilder
	{
		public List<Pizza> pizzas = new List<Pizza>();
		public List<Ingredients> ingredients = new List<Ingredients>();

		public TemporaryPizzaBuilder()
		{
			GeneratePizzas(10);
			GenerateIngredients(100);
		}

		private void GenerateIngredients(int amount)
		{
			for (int i = 0; i < amount; i++)
			{

			}
		}

		private void GeneratePizzas(int amount)
		{
			for (int i = 0; i < amount; i++)
			{

			}
		}
	}
}
