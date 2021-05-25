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
	public class SauceRepository
	{
		public PizzariaDB database;

		public SauceRepository(PizzariaDB _database)
		{
			database = _database;
		}

		public Sauce AddSauce(Sauce sauce)
		{
			database.Sauce.Add(sauce);
			database.SaveChanges();
			return sauce;
		}

		public void RemoveSauce(Guid id)
		{
			var sauce = database.Sauce.Find(id);
			database.Sauce.Remove(sauce);
			database.SaveChanges();
		}

		public Sauce GetSauce(Sauce sauce)
		{
			var chosen = database.Sauce.Where(x => x.Id == sauce.Id).FirstOrDefault();
			return chosen;
		}

		public Sauce GetSauceId(Guid Id)
		{
			var chosen = database.Sauce.Where(x => x.Id == Id).FirstOrDefault();
			return chosen;
		}

		public List<Sauce> GetAllSauce()
		{
			return database.Sauce.ToList();
		}

		public void AddOrUpdate(Sauce newSauce)
		{
			var sauce = database.Sauce.Where(x => x.Id == newSauce.Id).FirstOrDefault();
			if (sauce != null)
			{
				sauce = newSauce;
				database.Sauce.AddOrUpdate(sauce);
				database.SaveChanges();
			}
			else
				AddSauce(newSauce);
		}
	}
}
