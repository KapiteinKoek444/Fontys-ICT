using ContainerMovement_V2.Factories;
using ContainerMovement_V2.Logic;
using ContainerMovement_V2.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace UnitTest_ContainerMovement.Logic_test
{
	[TestClass]
	public class Balance_Tests
	{
		Dock Test_Dock = new Dock();
		int seed = 100;
		[TestMethod]
		public void CheckSides_Test()
		{
			//Arrange
			ShipContainer con = ContainerFactory.GenereateSpecificContainer(70000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Regular, 1)[0];

			Ship expected = ShipFactory.GenerateDefaultShip();
			expected.AddRegularContainer(con, ContainerMovement_V2.Objects.Enums.Types.Sides.Left);
			expected.AddRegularContainer(con, ContainerMovement_V2.Objects.Enums.Types.Sides.Right);
			expected.CheckBalance(false);

			Test_Dock.Ship.AddRegularContainer(con, ContainerMovement_V2.Objects.Enums.Types.Sides.Left);

			//Act
			Test_Dock.CheckSides(con);
			var actual = Test_Dock.Ship;
			actual.CheckBalance(false);

			//Assert
			Assert.AreEqual(expected.LeftWeight, actual.LeftWeight);
			Assert.AreEqual(expected.RightWeight, actual.RightWeight);
		}

		[TestMethod]
		public void LeftSide_Test()
		{
			//Arrange
			Dock dock = new Dock();
			dock.AssignShip(new System.Drawing.Size(4, 2), 100000);

			List<ShipContainer> containersLeft = ContainerFactory.GenereateSpecificContainer(4000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Regular, 12);
			foreach (var c in containersLeft)
				dock.Ship.AddRegularContainer(c, ContainerMovement_V2.Objects.Enums.Types.Sides.Left);

			List<ShipContainer> testContainers = ContainerFactory.GenereateSpecificContainer(5000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Regular, 10);
			
			//Act
			dock.AddContainer(testContainers);
			var side = dock.Ship.CheckBalance(false);

			//Assert

			Assert.AreEqual(ContainerMovement_V2.Objects.Enums.Types.Sides.Right, side);
		}

		[TestMethod]
		public void Impossible_Test()
		{
			//Arrange
			Dock dock = new Dock();
			dock.AssignShip(new System.Drawing.Size(1, 2), 20000);

			List<ShipContainer> cooledContainers = ContainerFactory.GenereateSpecificContainer(1000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Cooled, 10);
			dock.AddContainer(cooledContainers);
			dock.AssignContainers();

			//Act
			var actual = dock.Ship.CheckBalance(false);

			//Assert
			Assert.AreNotEqual(ContainerMovement_V2.Objects.Enums.Types.Sides.Left, actual);
		}

		[TestMethod]
		public void MaxValueable_Test()
		{
			//Arrange
			Dock dock = new Dock();
			dock.AssignShip(new System.Drawing.Size(2, 2), 20000);
			List<ShipContainer> valueableContainers = ContainerFactory.GenereateSpecificContainer(4000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Regular, 5);
			dock.AddContainer(valueableContainers);
			dock.AssignContainers();

			List<ShipContainer> container = ContainerFactory.GenereateSpecificContainer(4000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Valueable, 5);
			//Act
			bool actual = dock.AddRegularContainers(container);

			//Assert
			Assert.AreNotEqual(true, actual);
		}

		[TestMethod]
		public void SolveContainer_Test_01()
		{
			//Arrange
			List<ShipContainer> Containers = ContainerFactory.GenerateRandomContainers(100, seed);
			Test_Dock.AddContainer(Containers);
			bool expected = false;

			//Act
			bool actual = Test_Dock.AssignContainers();

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void AllToTheRight_Even()
		{
			//Arrange
			Dock dock = new Dock();
			dock.AssignShip(new System.Drawing.Size(4, 2), 200000);
			List<ShipContainer> RightContainers = ContainerFactory.GenereateSpecificContainer(8000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Regular, 10);
			List<ShipContainer> LeftContainers = ContainerFactory.GenereateSpecificContainer(3000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Regular, 20);
			
			//Act
			//Assert
		}

		[TestMethod]
		public void AllToTheRight_MiddleEven_UnEven()
		{
			//Arrange
			Dock dock = new Dock();
			//Act
			//Assert
		}
	}
}
