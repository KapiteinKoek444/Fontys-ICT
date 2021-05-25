using ContainerMovement_V2.Objects;
using ContainerMovement_V2.Objects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerMovement_V2.Factories
{
	public static class ContainerFactory
	{
		public static List<ShipContainer> GenerateRandomContainers(int amount, int seed)
		{
			Random rnd = new Random(seed);
			List<ShipContainer> containers = new List<ShipContainer>();

			for (int i = 0; i < amount; i++)
			{
				ShipContainer container;
				int weight = rnd.Next(4, 20);
				weight = weight * 1000;
				int type = rnd.Next(5);

				if (type == 1)
					container = new ShipContainer(weight, Types.ContainerTypes.Cooled);
				else if (type == 2)
					container = new ShipContainer(weight, Types.ContainerTypes.Valueable);
				else
					container = new ShipContainer(weight, Types.ContainerTypes.Regular);

				containers.Add(container);
			}

			return containers;
		}

		public static List<ShipContainer> GenereateSpecificContainer(int weight, Types.ContainerTypes type, int amount)
		{
			List<ShipContainer> containers = new List<ShipContainer>();

			for (int i = 0; i < amount; i++)
			{
				ShipContainer container = new ShipContainer(weight, type);
				containers.Add(container);
			}

			return containers;
		}

		public static List<ShipContainer> MergeLists(List<ShipContainer> currentList, List<ShipContainer> mergeList)
		{
			if (currentList == null)
				return mergeList;
			else if (mergeList == null)
				return currentList;
			else
			{
				foreach (var container in mergeList)
				{
					currentList.Add(container);
				}
			}
			return currentList;
		}
	}
}
