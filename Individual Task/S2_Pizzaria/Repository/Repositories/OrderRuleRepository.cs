using Repository.DBCon;
using Repository.Entities.Connections;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
	public class OrderRuleRepository
	{
		public PizzariaDB Database; 

		public OrderRuleRepository(PizzariaDB database)
		{
			Database = database;
		}

		public OrderRule RemoveOrderRule(Guid id)
		{
			var orderrule = Database.OrderRule.Find(id);
			Database.OrderRule.Remove(orderrule);
			Database.SaveChanges();
			return orderrule;
		}

		public OrderRule AddOrderRule(OrderRule rule)
		{
			Database.OrderRule.Add(rule);
			Database.SaveChanges();
			return rule;
		}

		public List<OrderRule> GetOrderRules()
		{
			return Database.OrderRule.ToList();
		}

		public OrderRule GetOrderRule(Guid Id)
		{
			return Database.OrderRule.Where(x => x.Id == Id).FirstOrDefault();
		}

		public void AddOrUpdate(OrderRule orderRuleNew)
		{
			var orderrule = Database.OrderRule.Where(x => x.Id == orderRuleNew.Id).FirstOrDefault();
			if (orderrule != null)
			{
				orderrule = orderRuleNew;
				Database.OrderRule.AddOrUpdate(orderrule);
				Database.SaveChanges();
			}
			else
				AddOrderRule(orderRuleNew);
		}
	}
}
