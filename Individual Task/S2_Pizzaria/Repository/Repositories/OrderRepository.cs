using Repository.DBCon;
using Repository.Entities.Connections;
using Repository.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
	public class OrderRepository
	{
		public PizzariaDB database;

		public OrderRepository(PizzariaDB _database)
		{
			database = _database;
		}

		public Order RemoveOrder(Guid id)
		{
			var order = database.Order.Find(id);
			database.Order.Remove(order);
			database.SaveChanges();
			return order;
		}

		public Order GetOrder(Order order)
		{
			return database.Order.Where(x => x.Id == order.Id).FirstOrDefault();
		}

		public Order GetOrderId(Guid Id)
		{
			return database.Order.Where(x => x.Id == Id).FirstOrDefault();
		}

		public List<Order> GetAllOrders()
		{
			return database.Order.ToList();
		}

		public Order UpdateOrder(Order paidOrder)
		{
			Order order = database.Order.Where(x => x.Id == paidOrder.Id).FirstOrDefault();

			if (order != null)
			{
				order = paidOrder;
				database.Order.AddOrUpdate(order);
				database.SaveChanges();
			}

			return paidOrder;
		}

		public Order AddOrder(Order order)
		{
			database.Order.Add(order);
			database.SaveChanges();
			return order;
		}

		public void AddOrUpdate(Order newOrder)
		{
			var order = database.Order.Where(x => x.Id == newOrder.Id).FirstOrDefault();
			if (order != null)
			{
				order = newOrder;
				database.Order.AddOrUpdate(order);
				database.SaveChanges();
			}
			else
				AddOrder(newOrder);
		}
	}
}
