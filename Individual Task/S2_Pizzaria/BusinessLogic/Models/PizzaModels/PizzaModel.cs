using BusinessLogic.Models.Base;
using Repository.Entities.Connections;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models.IngredientComponents
{
	public class PizzaModel : EntityModelBase
	{
		public Guid OrderRuleId { get; set; }
		
		public string Name { get; set; }
		public double Price { get; set; }
		public List<PizzaIngredientModel> PizzaIngredients { get; set; }
		public BottomModel Bottom { get; set; }
	}
}
