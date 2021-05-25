using BusinessLogic.Models;
using Repository.Entities.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Factory.ItemFactories
{
	public static class OrderRuleFactory
	{
		public static List<OrderRule> ConvertOrderRuleModels(List<OrderRuleModel> orderRuleModels)
		{
			List<OrderRule> orderRules = new List<OrderRule>();
			
			foreach (var model in orderRuleModels)
			{
				var orderrule = ConvertOrderRuleModel(model);
				orderRules.Add(orderrule);
			}

			return orderRules;
		}

		public static OrderRule ConvertOrderRuleModel(OrderRuleModel model)
		{
			if (model == null)
				return null;

			OrderRule orderRule = new OrderRule()
			{
				Id = model.Id,
				OrderId = model.OrderId,
				PizzaId = model.Pizza.Id
			};

			return orderRule;
		}
	}
}
