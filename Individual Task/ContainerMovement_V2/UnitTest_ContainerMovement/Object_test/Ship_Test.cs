using ContainerMovement_V2.Factories;
using ContainerMovement_V2.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace UnitTest_ContainerMovement.Object_test
{
	[TestClass]
	public class Ship_Test
	{
		Ship ship = ShipFactory.GenerateDefaultShip();

		[TestMethod]
		public void AddRegularContainer_Test()
		{
			//Arrange
			ShipContainer container = new ShipContainer(20000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Regular);
			Point expected = new Point(0, 1);

			//Act
			ship.AddRegularContainer(container, ContainerMovement_V2.Objects.Enums.Types.Sides.Middle);
			Point actual = ship.piles.Where(x => x.containers.Count > 0).Select(x => x.Location).FirstOrDefault();

			//Assert
			Assert.AreEqual(expected.X, actual.X);
			Assert.AreEqual(expected.Y, actual.Y);
		}

		[TestMethod]
		public void AddCooledContainer_Test()
		{
			//Arrange
			ShipContainer container = new ShipContainer(20000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Cooled);
			Point expected = new Point(0, 0);

			//Act
			ship.AddCooledContainer(container, ContainerMovement_V2.Objects.Enums.Types.Sides.Left);
			Point actual = ship.piles.Where(x => x.containers.Count > 0).Select(x => x.Location).FirstOrDefault();

			//Assert
			Assert.AreEqual(expected.X, actual.X);
			Assert.AreEqual(expected.Y, actual.Y);
		}

		[TestMethod]
		public void AddValueableContainer_Test()
		{
			//Arrange
			ShipContainer container = new ShipContainer(20000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Valueable);
			Point expected = new Point(0, 2);

			//Act
			ship.AddValueableContainer(container, ContainerMovement_V2.Objects.Enums.Types.Sides.Right);
			Point actual = ship.piles.Where(x => x.containers.Count > 0).Select(x => x.Location).FirstOrDefault();

			//Assert
			Assert.AreEqual(expected.X, actual.X);
			Assert.AreEqual(expected.Y, actual.Y);
		}

		[TestMethod]
		public void CheckOccupation_Test()
		{
			//Arrange
			ShipContainer container1 = new ShipContainer(20000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Regular);
			ship.AddRegularContainer(container1, ContainerMovement_V2.Objects.Enums.Types.Sides.Left);
			
			bool expected = false;

			//Act
			bool actual = ship.CheckOccupation(new Point(0, 0));

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CheckBalance_Test_01()
		{
			//Arrange
			ShipContainer container1 = new ShipContainer(30000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Regular);
			ShipContainer container2 = new ShipContainer(30000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Regular);
			ShipContainer container3 = new ShipContainer(1000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Regular);
			ship.AddRegularContainer(container1, ContainerMovement_V2.Objects.Enums.Types.Sides.Left);
			ship.AddRegularContainer(container2, ContainerMovement_V2.Objects.Enums.Types.Sides.Right);
			ship.AddRegularContainer(container3, ContainerMovement_V2.Objects.Enums.Types.Sides.Right);

			ContainerMovement_V2.Objects.Enums.Types.Sides expected = ContainerMovement_V2.Objects.Enums.Types.Sides.Middle;

			//Act
			ContainerMovement_V2.Objects.Enums.Types.Sides actual = ship.CheckBalance(false);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CheckBalance_Test_02()
		{
			//Arrange
			ShipContainer container1 = new ShipContainer(30000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Regular);
			ShipContainer container2 = new ShipContainer(30000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Regular);
			ShipContainer container3 = new ShipContainer(10000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Regular);
			ship.AddRegularContainer(container1, ContainerMovement_V2.Objects.Enums.Types.Sides.Left);
			ship.AddRegularContainer(container2, ContainerMovement_V2.Objects.Enums.Types.Sides.Left);
			ship.AddRegularContainer(container3, ContainerMovement_V2.Objects.Enums.Types.Sides.Right);

			ContainerMovement_V2.Objects.Enums.Types.Sides expected = ContainerMovement_V2.Objects.Enums.Types.Sides.Right;

			//Act
			ContainerMovement_V2.Objects.Enums.Types.Sides actual = ship.CheckBalance(false);

			//Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
