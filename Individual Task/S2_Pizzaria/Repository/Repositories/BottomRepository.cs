using Repository.DBCon;
using Repository.Entities.Pizza_Components.BottomType;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
	public class BottomRepository
	{
		public PizzariaDB database;

		public BottomRepository(PizzariaDB _database)
		{
			database = _database;
		}

		public Bottom GetBottom(Guid bottomId)
		{
			return database.Bottom.Where(x => x.Id == bottomId).FirstOrDefault();
		}

		public List<Bottom> GetAllBottoms()
		{
			return database.Bottom.ToList();
		}

		public Bottom AddBottom(Bottom bottom)
		{
			database.Bottom.Add(bottom);
			database.SaveChanges();
			return bottom;
		}

		public Bottom RemoveBottom(Guid id)
		{
			var bottom = database.Bottom.Find(id);
			database.Bottom.Remove(bottom);
			database.SaveChanges();
			return bottom;
		}

		public void AddOrUpdate(Bottom newBottom)
		{
			var bottom = database.Bottom.Where(x => x.Id == newBottom.Id).FirstOrDefault();
			if (bottom != null)
			{
				bottom = newBottom;
				database.Bottom.AddOrUpdate(bottom);
				database.SaveChanges();
			}
			else
				AddBottom(newBottom);
		}
	}
}
