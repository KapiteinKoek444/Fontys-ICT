using Pannekoeken_Sorter.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pannekoeken_Sorter
{
	public class Pancake
	{
		public int Width { get; set; }
		public int Height { get; set; }

		public Pancake(int width, int height)
		{
			Width = width;
			Height = height;
		}
	}
}
   