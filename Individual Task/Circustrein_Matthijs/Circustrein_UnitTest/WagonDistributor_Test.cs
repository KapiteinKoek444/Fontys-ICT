using Circustrein_Matthijs;
using Circustrein_Matthijs.Components;
using CircusTrein_Opdracht.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Circustrein_UnitTest
{
	[TestClass]
	public class WagonDistributor_Test
	{
		int seed = 100;
		[TestMethod]
		public void Distribute_Test_01()
		{
			//Arrange
			List<Animal> Animals1 = AnimalFactory.GenerateSelectAnimal(FoodEnum.FoodType.Carnivore, 3, 10);
			//Act
			List<Wagon> actualWagonList = WagonDistributor.Distribute(Animals1);

			//Assert
			for (int i = 0; i < actualWagonList.Count; i++)
			{
				Assert.AreEqual(Animals1[i], actualWagonList[i].FilledAnimals[0]);
			}
		}

		[TestMethod]
		public void Distribute_Test_02()
		{
			//Arrange
			List<Animal> carnivores = AnimalFactory.GenerateSelectAnimal(FoodEnum.FoodType.Carnivore, 1, 1);
			List<Animal> herbivores = AnimalFactory.GenerateSelectAnimal(FoodEnum.FoodType.Herbivore, 3, 3);

			List<Animal> merged = AnimalFactory.MergeAnimalLists(carnivores, herbivores);

			//Act
			List<Wagon> actual = WagonDistributor.Distribute(merged);

			//Assert
			Assert.AreEqual(1, actual.Count);
			Assert.AreEqual(4, actual[0].FilledAnimals);
			for (int i = 0; i < merged.Count; i++)
			{
				Assert.AreEqual(merged[i], actual[0].FilledAnimals[i]);
			}
		}

		[TestMethod]
		public void Distribute_Test_03()
		{
			//Arrange
			int expectedWagonAmount = 5;

			List<Animal> DistributedAnimals = AnimalFactory.GenerateCarnivores(expectedWagonAmount, seed);

			//Act
			List<Wagon> actualWagonList = WagonDistributor.Distribute(DistributedAnimals);

			//Assert
			Assert.AreEqual(expectedWagonAmount, actualWagonList.Count);
		}

		[TestMethod]
		public void Distribute_Test_04()
		{
			//Arrange
			List<Animal> herb = AnimalFactory.GenerateSelectAnimal(FoodEnum.FoodType.Herbivore, 1, 10);
			List<Animal> Carn = AnimalFactory.GenerateSelectAnimal(FoodEnum.FoodType.Carnivore, 3, 5);
			List<Animal> merged = AnimalFactory.MergeAnimalLists(herb, Carn);
			//Act
			List<Wagon> actualWagonList = WagonDistributor.Distribute(merged);

			//Assert
			foreach(var animal in merged)
			{
				var chosen = actualWagonList.Where(x => x.FilledAnimals.Contains(animal));
				Assert.IsNotNull(chosen);
			}
		}

		[TestMethod]
		public void AllAnimalsAdded_Test()
		{
			//Arrange
			int expected = 10;

			List<Wagon> wagons;
			List<Animal> animals = AnimalFactory.GenerateRandomAnimals(10, seed);

			//Act
			wagons = WagonDistributor.Distribute(animals);
			int actual = 0;

			foreach (var wagon in wagons)
			{
				actual += wagon.FilledAnimals.Count;
			}

			//Assert
			Assert.AreEqual(expected, actual);
		}

	}
}
