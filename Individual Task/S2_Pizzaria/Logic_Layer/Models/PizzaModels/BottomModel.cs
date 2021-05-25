using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_Layer.Models.IngredientComponents
{
	public class BottomModel
	{
		public SauceModel Sauce { get; set; }
		public double Radius { get; set; }
		public string BotType { get; set; }
		public bool Thick { get; set; }
	}
}
