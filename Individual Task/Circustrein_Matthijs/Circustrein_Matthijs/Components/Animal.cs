using System;
using System.Collections.Generic;
using System.Text;
using static Circustrein_Matthijs.Components.FoodEnum;

namespace CircusTrein_Opdracht.Components
{
	public class Animal
	{
		public FoodType Food { get; set; }
		public int Size { get; set; }

		public Animal(FoodType food, int size)
		{
			Food = food;
			Size = size;
		}
	}
}
