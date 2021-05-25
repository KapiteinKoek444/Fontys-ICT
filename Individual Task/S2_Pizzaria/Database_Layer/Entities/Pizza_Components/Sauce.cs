using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Layer.Entities.Pizza_Components
{
	public class Sauce
	{
		public string Name { get; set; }
		public bool IsSpicy { get; set; }
		public double Price { get; set; }

		public Sauce(string name, bool isSpicy, double price)
		{
			Name = name;
			IsSpicy = isSpicy;
			Price = price;
		}
	}
}
