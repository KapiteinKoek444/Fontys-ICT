using Pannekoeken_Sorter.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pannekoeken_Sorter
{
	public partial class Pancakes : Form
	{
		PancakeStack stack;

		public Pancakes()
		{
			InitializeComponent();
		}

		private void SolveButton_Click(object sender, EventArgs e)
		{
			stack.AutoSort();
			Visualise(stack.Pancakes);
		}

		private void Set_Pancakes_Click(object sender, EventArgs e)
		{
			stack = StackFactory.GenerateStack(Convert.ToInt32(numUDCount.Value),pnlPancakes.Height,pnlPancakes.Width);
			Visualise(stack.Pancakes);
		}

		private void Visualise(List<Pancake> pancakes)
		{
			pnlPancakes.Controls.Clear();
			for (int i = 0; i < pancakes.Count; i++)
			{
				Panel pnl = new Panel();
				pnl.Width = Convert.ToInt32(pancakes[i].Width);
				pnl.Height = Convert.ToInt32(pancakes[i].Height);
				pnl.Location = new Point((pnlPancakes.Width - pnl.Width) / 2, i * pnl.Height);
				pnl.BackColor = Color.Transparent;
				pnl.BorderStyle = BorderStyle.FixedSingle;
				pnlPancakes.Controls.Add(pnl);
			}
		}
	}
}
