using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pannekoeken_Sorter.Components
{
	public class PancakeStack
	{
		public List<Pancake> Pancakes = new List<Pancake>();

		public PancakeStack()
		{

		}

		public void AutoSort()
		{
			for (int arraylength = Pancakes.Count - 1; arraylength > 0; arraylength--)
			{
				int indexOfMax = IndexOfBiggest(arraylength);
				if (indexOfMax != arraylength)
				{
					Flip(indexOfMax);
					Flip(arraylength);
				}
			}
		}

		public void Flip(int end)
		{
			for (var start = 0; start < end; start++, end--)
			{
				var startpoint = Pancakes[start];
				Pancakes[start] = Pancakes[end];
				Pancakes[end] = startpoint;
			}
		}

		public int IndexOfBiggest(int n)
		{
			int index = 0;


			for (int i = 0; i <= n; i++)
			{
				if (Pancakes[index].Width < Pancakes[i].Width)
				{
					index = i;
				}
			}

			return index;
		}
	}
}
