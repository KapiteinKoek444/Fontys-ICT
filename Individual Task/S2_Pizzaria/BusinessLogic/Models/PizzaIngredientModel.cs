using BusinessLogic.Models.Base;
using BusinessLogic.Models.IngredientComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
	public class PizzaIngredientModel : EntityModelBase
	{
		public Guid PizzaId { get; set; }
		public IngredientModel Ingredient { get; set; }
	}
}
