using CircusTrein_Opdracht.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_Matthijs
{
	public class Train
	{
		public List<Wagon> Wagons { get; set; }

		public Train(List<Wagon> wagons)
		{
			Wagons = wagons;
		}
	}
}
