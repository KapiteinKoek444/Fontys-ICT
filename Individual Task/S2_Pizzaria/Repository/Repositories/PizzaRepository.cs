using Repository.DBCon;
using Repository.Entities.Pizza_Components;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
	public class PizzaRepository
	{
		public PizzariaDB database;

		public PizzaRepository(PizzariaDB _database)
		{
			database = _database;
		}

		public Pizza AddPizza(Pizza pizza)
		{
			database.Pizzas.Add(pizza);
			database.SaveChanges();
			return pizza;
		}

		public void RemovePizza(Guid id)
		{
			var pizza = database.Pizzas.Find(id);
			database.Pizzas.Remove(pizza);
			database.SaveChanges();
		}

		public Pizza GetPizza(Pizza pizza)
		{
			var chosen = database.Pizzas.Where(x => x.Id == pizza.Id).FirstOrDefault();
			return chosen;
		}

		public Pizza GetPizzaId(Guid Id)
		{
			var chosen = database.Pizzas.Where(x => x.Id == Id).FirstOrDefault();
			return chosen;
		}

		public List<Pizza> GetAllPizza()
		{
			return database.Pizzas.ToList();
		}

		public void UpdatePizza(Pizza pizza)
		{
			var unUpdatedPizza = database.Pizzas.Where(x => x.Id == pizza.Id).FirstOrDefault();
			if (unUpdatedPizza != null)
			{
				unUpdatedPizza = pizza;
				database.Pizzas.AddOrUpdate(unUpdatedPizza);
				database.SaveChanges();
			}
			else
				AddPizza(pizza);
		}
	}
}
