using Repository.DBCon;
using Repository.Entities.Connections;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
	public class Pizza_IngredientRepository
	{
		public PizzariaDB Database;

		public Pizza_IngredientRepository(PizzariaDB database)
		{
			Database = database;
		}

		public Pizza_Ingredient RemovePizIngredient(Guid id)
		{
			var pizing = Database.PizzaIngredient.Find(id);
			Database.PizzaIngredient.Remove(pizing);
			Database.SaveChanges();
			return pizing;
		}

		public Pizza_Ingredient AddPizza_Ingredients(Pizza_Ingredient pizIng)
		{
			Database.PizzaIngredient.Add(pizIng);
			Database.SaveChanges();
			return pizIng;
		}

		public List<Pizza_Ingredient> GetPizza_Ingredient()
		{
			return Database.PizzaIngredient.ToList();
		}

		public Pizza_Ingredient GetPizza_Ingredient(Guid Id)
		{
			return Database.PizzaIngredient.Where(x => x.Id == Id).FirstOrDefault();
		}

		public void AddOrUpdate(Pizza_Ingredient pizza_Ingredient)
		{
			var pizIng = Database.PizzaIngredient.Where(x => x.Id == pizza_Ingredient.Id).FirstOrDefault();
			if (pizIng != null)
			{
				pizIng = pizza_Ingredient;
				Database.PizzaIngredient.AddOrUpdate(pizIng);
				Database.SaveChanges();
			}
			else
				AddPizza_Ingredients(pizza_Ingredient);
		}
	}
}
