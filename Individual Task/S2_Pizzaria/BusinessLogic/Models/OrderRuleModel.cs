using BusinessLogic.Models.Base;
using BusinessLogic.Models.IngredientComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
	public class OrderRuleModel : EntityModelBase
	{
		public Guid OrderId { get; set; }
		public PizzaModel Pizza { get; set; }
	}
}
