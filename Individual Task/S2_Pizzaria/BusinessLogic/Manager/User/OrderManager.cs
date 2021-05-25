using BusinessLogic.Factory;
using BusinessLogic.Factory.ItemFactories;
using BusinessLogic.Factory.ModelFactories;
using BusinessLogic.Models;
using Repository.UnitOfWork;
using System;
using System.Linq;

namespace BusinessLogic.Manager.User
{
	public static class OrderManager
	{
		public static void RemoveOrder(OrderModel model)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var order = OrderFactory.ConvertOrderModel(model);
			unitOfWork.OrderRepository.RemoveOrder(order.Id);
		}

		public static OrderModel AddOrder(OrderModel orderMod)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			orderMod.Id = Guid.NewGuid();
			var order = OrderFactory.ConvertOrderModel(orderMod);
			unitOfWork.OrderRepository.AddOrder(order);
			return orderMod;
		}

		public static OrderModel GetOrder(Guid userID)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var orders = unitOfWork.OrderRepository.GetAllOrders();
			var model = OrderModelFactory.ConvertOrder(orders.Where(x => x.UserId == userID).FirstOrDefault());
			return model;
		}
	}
}
