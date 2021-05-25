using ContainerMovement_V2.Factories;
using ContainerMovement_V2.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_test.UnitTest_ContainerMovement
{
	[TestClass]
	public class ShipFactory_Test
	{
		[TestMethod]
		public void AddDefaultShip_Test()
		{
			//Arrange
			Ship expected = new Ship(new System.Drawing.Size(4, 3), 400000);
			Ship actual;

			//Act
			actual = ShipFactory.GenerateDefaultShip();

			//Assert
			Assert.AreEqual(expected.Size, actual.Size);
			Assert.AreEqual(expected.MaxWeight, actual.MaxWeight);
		}

		[TestMethod]
		public void AddCustomShip()
		{
			//Arrange
			int expectedWeight = 100 * 1000;
			Ship actual;

			//Act
			actual = ShipFactory.GenerateCustomShip(100, new System.Drawing.Size(4,3));

			//Assert
			Assert.AreEqual(expectedWeight, actual.MaxWeight);
		}
	}
}
