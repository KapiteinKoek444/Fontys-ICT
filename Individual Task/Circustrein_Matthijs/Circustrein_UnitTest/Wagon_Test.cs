using Circustrein_Matthijs.Components;
using CircusTrein_Opdracht.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Circustrein_UnitTest
{
	[TestClass]
	public class Wagon_Test
	{
		[TestMethod]
		public void AddAnimal_Test()
		{
			//Arrange
			int expectedAmount = 2;
			List<Animal> animalList = new List<Animal>();

			Animal animal2 = new Animal(FoodEnum.FoodType.Herbivore, 5);
			Animal animal1 = new Animal(FoodEnum.FoodType.Carnivore, 3);

			animalList.Add(animal1);
			animalList.Add(animal2);

			Wagon actualWagon = new Wagon();

			//Act
			foreach (var a in animalList)
				actualWagon.AddAnimal(a);

			//Assert
			Assert.AreEqual(expectedAmount, actualWagon.FilledAnimals.Count);
		}

		[TestMethod]
		public void CalculateCarryWeight_Test()
		{
			//Arrange
			int expectedCarryWeight = 5;
			Animal animal = new Animal(FoodEnum.FoodType.Carnivore, 5);

			Wagon wagon = new Wagon();
			wagon.AddAnimal(animal);

			//Act
			int actualCarryWeight = wagon.CalculateCarryweight();

			//Assert
			Assert.AreEqual(expectedCarryWeight, actualCarryWeight);
		}

		[TestMethod]
		public void CheckAnimal_Test()
		{
			//Arrange
			bool expectedOutcome = false;
			Wagon wagon = new Wagon();

			Animal carnivore = new Animal(FoodEnum.FoodType.Carnivore, 5);
			Animal herbivore = new Animal(FoodEnum.FoodType.Herbivore, 3);

			wagon.AddAnimal(carnivore);
			//Act
			bool actualOutcome = wagon.CheckAnimal(herbivore);

			//Assert
			Assert.AreEqual(expectedOutcome, actualOutcome);
		}

		[TestMethod]
		public void CheckContents_Test()
		{
			//Arrange
			Animal expected1 = new Animal(FoodEnum.FoodType.Carnivore, 5);
			Wagon wagon = new Wagon();

			Animal actual = AnimalFactory.GenerateSelectAnimal(FoodEnum.FoodType.Carnivore, 5, 1).FirstOrDefault();
			//Act
			wagon.AddAnimal(actual);

			//Assert
			Assert.AreEqual(expected1.Food, wagon.FilledAnimals.FirstOrDefault().Food);
			Assert.AreEqual(expected1.Size, wagon.FilledAnimals.FirstOrDefault().Size);
		}
	}
	}
}

