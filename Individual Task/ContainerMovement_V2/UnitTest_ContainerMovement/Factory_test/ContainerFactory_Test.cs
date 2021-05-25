using ContainerMovement_V2.Factories;
using ContainerMovement_V2.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTest_ContainerMovement.Object_test;

namespace Factory_test.UnitTest_ContainerMovement
{
	[TestClass]
	public class ContainerFactory_Test
	{
		[TestMethod]
		public void AddRandomContainers_Test()
		{
			//Arrange
			int expectedAmount = 10;
			List<ShipContainer> containers;

			//Act
			containers = ContainerFactory.GenerateRandomContainers(10);
			//Assert
			Assert.AreEqual(expectedAmount, containers.Count);
		}

		[TestMethod]
		public void AddCustomContainer_test()
		{
			//Arrange
			ShipContainer expected = new ShipContainer(7000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Cooled);
			ShipContainer actual;

			//Act
			List<ShipContainer> containers = ContainerFactory.GenereateSpecificContainer(7000, ContainerMovement_V2.Objects.Enums.Types.ContainerTypes.Cooled, 1);
			actual = containers[0];

			//Assert
			Assert.AreEqual(expected.Type, actual.Type);
			Assert.AreEqual(expected.Weight, actual.Weight);
		}

		[TestMethod]
		public void MergeList_Test()
		{
			//Arrange
			List<ShipContainer> actual;
			List<ShipContainer> containers1;
			List<ShipContainer> containers2;

			int con1 = 10;
			int con2 = 7;
			int expected = con1 + con2;

			containers1 = ContainerFactory.GenerateRandomContainers(con1);
			containers2 = ContainerFactory.GenerateRandomContainers(con2);

			
			//Act
			actual = ContainerFactory.MergeLists(containers2, containers1);

			//Assert
			Assert.AreEqual(expected, actual.Count);
		}
	}
}
