using BusinessLogic.Models;
using Repository.Entities.Connections;
using Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Factory.ModelFactories
{
	public static class OrderRuleModelFactory
	{
		public static List<OrderRuleModel> ConvertOrderRules(List<OrderRule> orderrules)
		{
			List<OrderRuleModel> models = new List<OrderRuleModel>();
			foreach(var orderrule in orderrules)
			{
				var model = ConvertOrderRule(orderrule);
				models.Add(model);
			}

			return models;
		}

		public static OrderRuleModel ConvertOrderRule(OrderRule orderrule)
		{
			if (orderrule == null)
				return null;
			var pizzaModel = PizzaModelFactory.GetPizzaModel(orderrule.PizzaId);
			OrderRuleModel model = new OrderRuleModel
			{
				Id = orderrule.Id,
				OrderId = orderrule.OrderId,
				Pizza = pizzaModel
			};

			return model;
		}

		public static OrderRuleModel GetOrderRuleModel(Guid Id)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var orderrule = unitOfWork.OrderRuleRepository.GetOrderRule(Id);
			var model = ConvertOrderRule(orderrule);
			return model;
		}
	}
}
