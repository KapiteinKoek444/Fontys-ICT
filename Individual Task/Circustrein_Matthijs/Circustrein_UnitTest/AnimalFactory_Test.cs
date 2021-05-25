using Circustrein_Matthijs.Components;
using CircusTrein_Opdracht.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein_UnitTest
{
	[TestClass]
	public class AnimalFactory_Test
	{
		int seed = 100;
		[TestMethod]
		public void GenerateRandomList_Test()
		{
			//Arrange
			int expectedAmount = 3;

			//Act
			List<Animal> actualAnimalList = AnimalFactory.GenerateRandomAnimals(expectedAmount, seed);

			//Assert
			Assert.AreEqual(expectedAmount, actualAnimalList.Count);
		}

		[TestMethod]
		public void GenerateRandomCarnivores_Test()
		{
			//Arrange
			List<Animal> expectedCarnivoreList = new List<Animal>();
			int amount = 5;
			for (int i = 0; i < amount; i++)
			{
				Animal animal = new Animal(FoodEnum.FoodType.Carnivore, 3);
				expectedCarnivoreList.Add(animal);
			}

			//Act
			List<Animal> actualCarnivoreList = AnimalFactory.GenerateCarnivores(amount, seed);

			//Assert
			Assert.AreEqual(expectedCarnivoreList[4].Food, actualCarnivoreList[4].Food);
		}

		[TestMethod]
		public void GenerateRandomHerbivores_Test()
		{
			//Arrange
			List<Animal> expectedHerbivoreList = new List<Animal>();
			int amount = 5;
			for (int i = 0; i < amount; i++)
			{
				Animal animal = new Animal(FoodEnum.FoodType.Herbivore, 3);
				expectedHerbivoreList.Add(animal);
			}

			//Act
			List<Animal> actualHerbivoreList = AnimalFactory.GenerateHerbivores(amount, seed);

			//Assert
			Assert.AreEqual(expectedHerbivoreList[2].Food, actualHerbivoreList[2].Food);
		}

		[TestMethod]
		public void GenerateSelectedAnimals_Test()
		{
			//Arrange
			Animal expectedAnimal = new Animal(FoodEnum.FoodType.Carnivore, 3);

			int amount = 2;
			int size = 3;
			FoodEnum.FoodType food = FoodEnum.FoodType.Carnivore;

			//Act
			List <Animal> testingAnimals = AnimalFactory.GenerateSelectAnimal(food, size, amount);

			//Assert
			Assert.AreEqual(expectedAnimal.Food, testingAnimals[1].Food);
			Assert.AreEqual(expectedAnimal.Size, testingAnimals[1].Size);
		}

		[TestMethod]
		public void MergeAnimalLists_Test()
		{
			//Arrange
			List<Animal> expectedAnimalList = new List<Animal>();
			Animal animal1 = new Animal(FoodEnum.FoodType.Carnivore, 5);
			Animal animal2 = new Animal(FoodEnum.FoodType.Herbivore, 1);
			expectedAnimalList.Add(animal1);
			expectedAnimalList.Add(animal2);

			List<Animal> animal1List = new List<Animal>();
			animal1List.Add(animal1);
			List<Animal> animal2List = new List<Animal>();
			animal2List.Add(animal2);

			//Act
			List<Animal> actualAnimalList = AnimalFactory.MergeAnimalLists(animal1List, animal2List);

			//Assert
			Assert.AreEqual(expectedAnimalList.Count, actualAnimalList.Count);
		}
	}
}
