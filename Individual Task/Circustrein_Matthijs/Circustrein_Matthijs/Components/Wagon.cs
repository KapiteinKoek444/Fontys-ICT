using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Circustrein_Matthijs.Components.FoodEnum;

namespace CircusTrein_Opdracht.Components
{
	public class Wagon
	{
		public readonly List<Animal> FilledAnimals = new List<Animal>();
		private readonly int MaxWeight;

		public Wagon(int weight = 10)
		{
			MaxWeight = weight;
		}

		public void AddAnimal(Animal animal)
		{
			if (CheckAnimal(animal))
			{
				FilledAnimals.Add(animal);
			}
		}

		public bool CheckAnimal(Animal newAnimal)
		{
			if (FilledAnimals.Sum(animal => animal.Size) + newAnimal.Size > MaxWeight)
				return false;

			if (FilledAnimals.Any(animal => animal.Food == FoodType.Carnivore))
				return !(newAnimal.Food == FoodType.Carnivore || newAnimal.Size <= FilledAnimals.First(animal => animal.Food == FoodType.Carnivore).Size);

			if (FilledAnimals.Count > 0)
				return !(newAnimal.Food == FoodType.Carnivore && newAnimal.Size > FilledAnimals.Min(animal => animal.Size));

			return true;
		}

		public int CalculateCarryweight()
		{
			int count = 0;

			foreach (var a in FilledAnimals)
				count += a.Size;

			return count;
		}
	}
}
