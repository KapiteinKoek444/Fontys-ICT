using BusinessLogic.Models.Base;
using BusinessLogic.Models.IngredientComponents;
using Repository.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
	public class OrderModel : EntityModelBase
	{
		public Guid UserId { get; set; }
		public List<OrderRuleModel> OrderRules { get; set; }
	}
}
