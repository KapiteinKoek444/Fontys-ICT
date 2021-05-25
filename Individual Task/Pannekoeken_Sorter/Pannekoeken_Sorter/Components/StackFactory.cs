using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pannekoeken_Sorter.Components
{
	public static class StackFactory
	{
		public static PancakeStack GenerateStack(int amount, int _height, int width)
		{
			PancakeStack stack = new PancakeStack();
			Random rnd = new Random();

			int height = (_height / amount);

			for (int i = 0; i < amount; i++)
			{

					int w = rnd.Next(0, width);
					Pancake pancake = new Pancake(w, height);
					stack.Pancakes.Add(pancake);
			}

			return stack;
		}
	}
}
