using BusinessLogic.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models.IngredientComponents
{
	public class BottomModel : EntityModelBase
	{
		public SauceModel Sauce { get; set; }
		public double Surface { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		public bool Thick { get; set; }
	}
}
