using Circustrein_Matthijs.Components;
using CircusTrein_Opdracht.Components;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Circustrein_Matthijs.Components.FoodEnum;

namespace Circustrein_Matthijs
{
	public partial class CircusTrein : Form
	{
		List<Animal> AllAnimalList = new List<Animal>();
		List<Wagon> AllWagonList = new List<Wagon>();
		int AnimalAmount;
		int seed = 100;

		public CircusTrein()
		{
			InitializeComponent();
		}


		//Functionality
		//Sorting animals
		private void Sort_Animals_Click(object sender, EventArgs e)
		{
			List<Animal> AnimalsSorted = AllAnimalList.OrderBy(animal => animal.Size).ThenBy(animal => animal.Food == FoodType.Carnivore).ToList();

			SetAnimalBox(AnimalsSorted);
		}

		//Distributing Animals
		private void Distribute_Animals_Click(object sender, EventArgs e)
		{
			AllWagonList = Components.WagonDistributor.Distribute(AllAnimalList);
			SetWagonBox(AllWagonList);
		}

		//Clear Animals
		private void ClearAnimals_Click(object sender, EventArgs e)
		{
			tboxAnimals.Text = "";
			AllAnimalList.Clear();
		}


		//Naming Components:
		//Animals
		private void SetAnimalBox(List<Animal> Animals)
		{
			tboxAnimals.Text = "";
			for (int i = 0; i < Animals.Count; i++)
			{
				tboxAnimals.Text += Animals[i].Size.ToString();
				tboxAnimals.Text += Animals[i].Food.ToString();
				tboxAnimals.Text += "\r\n";
			}
		}
		//Wagons
		private void SetWagonBox(List<Wagon> Wagons)
		{
			string wagonstring = "";
			tboxWagons.Text = wagonstring;

			for (int i = 0; i < Wagons.Count; i++)
			{
				wagonstring += $"Wagon{i}";
				wagonstring += "\r\n";

				for (int j = 0; j < Wagons[i].FilledAnimals.Count; j++)
				{
					wagonstring += Wagons[i].FilledAnimals[j].Size.ToString();
					wagonstring += Wagons[i].FilledAnimals[j].Food.ToString();
					wagonstring += "\r\n";
				}

				wagonstring += "\r\n";
			}
			tboxWagons.Text += wagonstring;
		}

		//Adding:
		//RandomAnimals
		private void AddAnimals_Click(object sender, EventArgs e)
		{
			int animalAmount = Convert.ToInt32(numUDAnimalCount.Value);

			List<Animal> ToBeAddedAnimals = AnimalFactory.GenerateRandomAnimals(animalAmount, seed);
			AllAnimalList = AnimalFactory.MergeAnimalLists(AllAnimalList, ToBeAddedAnimals);

			SetAnimalBox(AllAnimalList);
			CheckFactory(animalAmount);
		}

		//Specific Animal
		private void AddSpecificAnimal_Click(object sender, EventArgs e)
		{
			int animalSize = Convert.ToInt32(cBSize);
			int animalAmount = Convert.ToInt32(numUDAnimalCount.Value);
			var type = new FoodType();

			if (cBCarnivore.Text == "Carnivore")
				type = FoodType.Carnivore;
			else if (cBCarnivore.Text == "Herbivore")
				type = FoodType.Herbivore;
			else if (cBCarnivore.Text == "Omnivore")
				type = FoodType.Omnivore;

			List<Animal> AnimalsToBeAdded = AnimalFactory.GenerateSelectAnimal(type, animalSize, animalAmount);
			AllAnimalList = AnimalFactory.MergeAnimalLists(AllAnimalList, AnimalsToBeAdded);

			SetAnimalBox(AllAnimalList);
			CheckFactory(animalAmount);
		}

		//Add Herbivores
		private void AddHerbivores_Click(object sender, EventArgs e)
		{
			int animalAmount = Convert.ToInt32(numUDAnimalCount.Value);

			List<Animal> ToBeAddedAnimals = AnimalFactory.GenerateHerbivores(animalAmount, seed);
			AllAnimalList = AnimalFactory.MergeAnimalLists(AllAnimalList, ToBeAddedAnimals);

			SetAnimalBox(AllAnimalList);
			CheckFactory(animalAmount);
		}

		//Add Carnivores
		private void AddCarnivores_Click(object sender, EventArgs e)
		{
			int animalAmount = Convert.ToInt32(numUDAnimalCount.Value);

			List<Animal> ToBeAddedAnimals = AnimalFactory.GenerateCarnivores(animalAmount, seed);
			AllAnimalList = AnimalFactory.MergeAnimalLists(AllAnimalList, ToBeAddedAnimals);

			SetAnimalBox(AllAnimalList);
			CheckFactory(animalAmount);
		}

		public void CheckFactory(int amount)
		{
			if (AllAnimalList.Count == AnimalAmount + amount)
			{
				MessageBox.Show("Succesfully added animals");
				AnimalAmount += amount;
			}
			else
			{
				MessageBox.Show("Animals were not added");
			}
		}
	}
}
