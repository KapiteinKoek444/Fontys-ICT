using Data_Layer.Entities.Pizza_Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Entities.Pizza_Components.BottomType
{
	public class Bottom
	{
		public double Price;
		public double PricePerCM = 0.1;
		public double MaxSurface { get; }
		public double MinSurface { get; }
		public double Radius { get; set; }
		public string BotType { get; set; }
		public bool Thick { get; set; }
		public Sauce Sauce { get; set; }

		public Bottom(double radius, string botType, bool thick, Sauce sauce)
		{
			Price = CalculatePrice();
			MaxSurface = 2500;
			MinSurface = 0.5;
			Radius = radius;
			BotType = botType;
			Thick = thick;
			Sauce = sauce;
		}

		public double CalculatePrice()
		{
			var bottomPrice = PricePerCM * Math.PI * (Radius * Radius);
			var saucePrice = Sauce.Price * Math.PI * (Radius * Radius);

			var botPrice = bottomPrice + saucePrice;

			return botPrice;
		}
	}
}
