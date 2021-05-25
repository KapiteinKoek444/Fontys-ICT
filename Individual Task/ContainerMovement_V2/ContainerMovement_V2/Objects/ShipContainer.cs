using ContainerMovement_V2.Objects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerMovement_V2.Objects
{
	public class ShipContainer
	{
		public int Weight { get; set; }
		public Types.ContainerTypes Type { get; set; }

		public ShipContainer(int weight, Types.ContainerTypes type)
		{
			Weight = weight;
			Type = type;
		}
	}
}
