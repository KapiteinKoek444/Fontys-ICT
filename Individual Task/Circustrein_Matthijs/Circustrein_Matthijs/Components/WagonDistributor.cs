using CircusTrein_Opdracht.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Circustrein_Matthijs.Components.FoodEnum;

namespace Circustrein_Matthijs.Components
{
	public class WagonDistributor
	{

		public static List<Wagon> Distribute(List<Animal> AllAnimals)
		{
			List<Wagon> filledWagons = new List<Wagon>();
			AllAnimals = AllAnimals.OrderBy(animal => animal.Size).ToList();

			List<Animal> Herbivores = AllAnimals.Where(animal => animal.Food != FoodType.Carnivore).ToList();
			List<Wagon> wagons = new List<Wagon>();

			if (Herbivores.Count != AllAnimals.Count)
			{
				wagons = AllAnimals.Where(animal => animal.Food == FoodType.Carnivore).Select(animal =>
				{
					var newWagon = new Wagon();
					newWagon.AddAnimal(animal);
					return newWagon;
				}).ToList();
			}
			else
			{
				Wagon wagon = new Wagon();
				wagons.Add(wagon);
			}
	
			int wagoncount = 0;
			foreach (Animal herbivore in Herbivores)
			{
				while (true)
				{
					if (wagons[wagoncount].CheckAnimal(herbivore))
					{
						wagons[wagoncount].AddAnimal(herbivore);
						wagoncount = 0;
						break;
					}
					else if (wagoncount + 1 < wagons.Count)
					{
						wagoncount++;
					}
					else
					{
						Wagon wagon = new Wagon();
						wagon.AddAnimal(herbivore);
						wagons.Add(wagon);
						wagoncount++;
						break;
					}
				}
			}

			foreach (Wagon wagon in wagons)
			{
				foreach (Animal animal in wagon.FilledAnimals)
				{
					AllAnimals.Remove(animal);
				}

				filledWagons.Add(wagon);
			}

			return filledWagons;
		}
	}
}
