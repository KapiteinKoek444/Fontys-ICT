using ContainerMovement_V2.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerMovement_V2.Factories
{
	public static class ShipFactory
	{
		public static Ship GenerateCustomShip(int maxWeight, Size size)
		{
			return new Ship(size, maxWeight * 1000);
		}

		public static Ship GenerateDefaultShip()
		{
			return new Ship(new Size(4, 3), 400 * 1000);
		}
	}
}
