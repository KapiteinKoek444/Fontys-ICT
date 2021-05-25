using Repository.DBCon;
using Repository.Entities.Pizza_Components.IngredientTypes;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
	public class IngredientRepository
	{
		public PizzariaDB database;

		public IngredientRepository(PizzariaDB _database)
		{
			database = _database;
		}

		public void AddIngredients(List<Ingredients> ingredients)
		{
			foreach (var ing in ingredients)
				AddIngredient(ing);
		}

		public void AddIngredient(Ingredients ingredient)
		{
			database.Ingredient.Add(ingredient);
			database.SaveChanges();
		}

		public void RemoveIngredient(Guid id)
		{
			var ingredient = database.Ingredient.Find(id);
			database.Ingredient.Remove(ingredient);
			database.SaveChanges();
		}

		public List<Ingredients> GetAllIngredients()
		{
			var ingredients = database.Ingredient.ToList();
			return ingredients;
		}

		public Ingredients GetIngredient(Guid Id)
		{
			return database.Ingredient.Where(x => x.Id == Id).FirstOrDefault();
		}

		public void AddOrUpdate(Ingredients newing)
		{
			var ingredient = database.Ingredient.Where(x => x.Id == newing.Id).FirstOrDefault();
			if (ingredient != null)
			{
				ingredient = newing;
				database.Ingredient.AddOrUpdate(ingredient);
				database.SaveChanges();
			}
			else
				AddIngredient(newing);
		}
	}
}
