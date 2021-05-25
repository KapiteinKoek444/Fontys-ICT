using BusinessLogic.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models.IngredientComponents
{
	public class SauceModel : EntityModelBase
	{
		public Guid BottomId { get; set; }
		public string Name { get; set; }
		public bool IsSpicy { get; set; }
		public double Price { get; set; }
	}
}
