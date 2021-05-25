using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerMovement_V2.Objects
{
	public class Stack
	{
		public readonly List<ShipContainer> containers = new List<ShipContainer>();
		public int height = 0;
		
		public Point Location { get; set; }

		public Stack(Point location)
		{
			Location = location;
		}

		public int getWeight()
		{
			int weight = 0;
			foreach (var c in containers)
				weight += c.Weight;

			return weight;
		}

		public bool AddContainer(ShipContainer container)
		{
			int stackedWeight = 0;

			for (int i = 1; i < containers.Count; i++)
				stackedWeight += containers[i].Weight;

			if (stackedWeight + container.Weight > 120000)
				return false;

			containers.Add(container);
			height++;
			return true;
		}
	}
}
