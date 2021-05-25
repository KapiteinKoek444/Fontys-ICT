using ContainerMovement_V2.Factories;
using ContainerMovement_V2.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest_ContainerMovement.Object_test
{
	[TestClass]
	public class Stack_Test
	{
		[TestMethod]
		public void GetWeight_Test()
		{
			//Arrange
			int expected = 7 * 7000;
			
			List<ShipContainer> containers = ContainerFactory.GenereateSpecificContainer(7000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Regular, 7);
			Stack stack = new Stack(new System.Drawing.Point(0, 0));

			foreach (var c in containers)
			{
				stack.AddContainer(c);
			}

			//Act
			int actual = stack.getWeight();

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void AddContainer_Test_01()
		{
			//Arrange
			bool expected = true;

			ShipContainer added = new ShipContainer(1000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Cooled);
			List<ShipContainer> containers = ContainerFactory.GenereateSpecificContainer(7000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Regular, 7);
			Stack stack = new Stack(new System.Drawing.Point(0, 0));
			
			foreach (var c in containers)
			{
				stack.AddContainer(c);
			}

			//Act
			bool actual = stack.AddContainer(added);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void AddContainer_Test_02()
		{
			//Arrange
			bool expected = false;

			ShipContainer added = new ShipContainer(20000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Cooled);
			List<ShipContainer> containers = ContainerFactory.GenereateSpecificContainer(10000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Regular, 12);
			Stack stack = new Stack(new System.Drawing.Point(0, 0));

			foreach (var c in containers)
			{
				stack.AddContainer(c);
			}

			//Act
			bool actual = stack.AddContainer(added);

			//Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
