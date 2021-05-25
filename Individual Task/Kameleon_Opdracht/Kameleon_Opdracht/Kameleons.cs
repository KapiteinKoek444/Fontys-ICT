using Kameleon_Opdracht.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kameleon_Opdracht
{
	public partial class Kameleons : Form
	{
		List<Chameleon> chameleons = new List<Chameleon>();

		public Kameleons()
		{
			InitializeComponent();
		}

		private void Start_Simulation_Click(object sender, EventArgs e)
		{
			int red = Convert.ToInt32(numUDRedChameleon.Value);
			int blue = Convert.ToInt32(numUDBlueChameleon.Value);
			int green = Convert.ToInt32(numUDGreenChameleon.Value);

			chameleons = CreateChameleons.GenerateChameleons(red, blue, green);

			tmrMain.Enabled = true;
		}

		private void Reset_Click(object sender, EventArgs e)
		{
			tmrMain.Enabled = false;
			pnlVisualisation.Controls.Clear();
			chameleons.Clear();
			tboxCoordinates.Text = "";
		}

		private void TmrMain_Tick(object sender, EventArgs e)
		{
			pnlVisualisation.Controls.Clear();
			tboxCoordinates.Text = "";
			
			for (int i = 0; i < chameleons.Count; i++)
			{
				chameleons[i].MoveLocation();
				chameleons[i].CheckBorders(pnlVisualisation);
				VisualizeChameleons(chameleons[i]);

				for (int j = 0; j < chameleons.Count; j++)
				{
					chameleons[i].ColorCheck(chameleons[j]);
				}

				tboxCoordinates.Text += $"Chameleon{i}:" + "\r\n";
				tboxCoordinates.Text += chameleons[i].Location.X.ToString();
				tboxCoordinates.Text += " , ";
				tboxCoordinates.Text += chameleons[i].Location.Y.ToString();
				tboxCoordinates.Text += "\r\n";
				tboxCoordinates.Text += chameleons[i].Color.ToString();
				tboxCoordinates.Text += "\r\n";
			}

		}

		private void VisualizeChameleons(Chameleon ch)
		{
			Panel pnl = new Panel();
			pnl.Size = ch.Size;
			pnl.Location = ch.Location;
			if (ch.Color == Components.Enums.ChameleonTypes.Colors.Red)
				pnl.BackColor = Color.Red;
			else if (ch.Color == Components.Enums.ChameleonTypes.Colors.Blue)
				pnl.BackColor = Color.Blue;
			else
				pnl.BackColor = Color.Green;

			pnlVisualisation.Controls.Add(pnl);
		}
	}
}
