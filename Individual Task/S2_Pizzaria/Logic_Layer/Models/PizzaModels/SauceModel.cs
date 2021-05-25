using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_Layer.Models.IngredientComponents
{
	public class SauceModel : IngredientModel
	{
		public enum SauceType
		{
			Pesto,
			Tomato,
			special
		}

		public Enum Type { get; set; }
	}
}
