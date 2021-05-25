using ContainerMovement_V2.Factories;
using ContainerMovement_V2.Logic;
using ContainerMovement_V2.Objects.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerMovement_V2
{
	public partial class containerMovementForm : Form
	{
		Dock dock;
		int seed = 100;
		List<TextBox> tboxes = new List<TextBox>();

		public containerMovementForm()
		{
			InitializeComponent();
		}

		private void AddContainers_Click(object sender, EventArgs e)
		{
			int amount = (int)numUDContainerAmount.Value;
			dock.AddContainer(ContainerFactory.GenerateRandomContainers(amount, seed));

			VisualiseContainers();
		}

		private void SolveDock_Click(object sender, EventArgs e)
		{
			if (dock.AssignContainers())
				MessageBox.Show("succes");
			else
				MessageBox.Show("Failed");

			VisualiseContainers();
		}

		public void VisualiseContainers()
		{
			tboxUnassignedContainer.Text = " ";

			foreach (var container in dock.unassignedContainers)
			{
				tboxUnassignedContainer.Text += container.Type.ToString();
				tboxUnassignedContainer.Text += " ";
				tboxUnassignedContainer.Text += container.Weight.ToString();
				tboxUnassignedContainer.Text += "\r\n";
			}

			int amount = 0;
			foreach (var box in tboxes)
			{
				box.Text = " ";
				foreach (var container in dock.Ship.piles[amount].containers)
				{
					box.Text += container.Type.ToString();
					box.Text += " ";
					box.Text += container.Weight.ToString();
					box.Text += "\r\n";
				}
				amount++;
			}

			tboxShipInfo.Text = " ";
			tboxShipInfo.Text += "Total weight: ";
			tboxShipInfo.Text += dock.Ship.Weight.ToString();
			tboxShipInfo.Text += "\r\n";
			tboxShipInfo.Text += "Left weight: ";
			tboxShipInfo.Text += dock.Ship.LeftWeight.ToString();
			tboxShipInfo.Text += "\r\n";
			tboxShipInfo.Text += "Right weight: ";
			tboxShipInfo.Text += dock.Ship.RightWeight.ToString();
			tboxShipInfo.Text += "\r\n";
		}

		private void btnGenerateShip_Click(object sender, EventArgs e)
		{
			gboxShipBuilder.Enabled = false;
			gboxContainerBuilder.Enabled = true;
			tboxShipInfo.Enabled = true;
			tboxUnassignedContainer.Enabled = true;
			btnSolve.Enabled = true;

			dock = new Dock();
			Size size = new Size(Convert.ToInt32(NumUdWidth.Value), Convert.ToInt32(numUdHeight.Value));
			dock.AssignShip(size, Convert.ToInt32(numUdWeight.Value));

			int width = (flpPiles.Width / size.Width) - 10;
			int height = (flpPiles.Height / size.Height) - 10;

			foreach (var pile in dock.Ship.piles)
			{
				TextBox tbox = new TextBox();
				tbox.Multiline = true;
				tbox.Size = new Size(width, height);
				tboxes.Add(tbox);
				flpPiles.Controls.Add(tbox);
			}
		}

		private void btnGenerateDefaultShip_Click(object sender, EventArgs e)
		{
			gboxShipBuilder.Enabled = false;
			gboxContainerBuilder.Enabled = true;
			tboxShipInfo.Enabled = true;
			tboxUnassignedContainer.Enabled = true;
			btnSolve.Enabled = true;

			dock = new Dock();

			Size size = new Size(Convert.ToInt32(NumUdWidth.Value), Convert.ToInt32(numUdHeight.Value));

			int width = (flpPiles.Width / size.Width) - (size.Width * (size.Width * 2));
			int height = (flpPiles.Height / size.Height) - (size.Height * (size.Height * 2));

			foreach (var pile in dock.Ship.piles)
			{
				TextBox tbox = new TextBox();
				tbox.Multiline = true;
				tbox.Size = new Size(width, height);
				tboxes.Add(tbox);
				flpPiles.Controls.Add(tbox);
			}
		}

		private void btnCustomContainer_Click(object sender, EventArgs e)
		{
			int amount = (int)numUDContainerAmount.Value;
			int weight = (int)numUdWeightCon.Value;

			var type = Types.ContainerTypes.Regular;

			if (comboContainerType.Text == "Valueable")
				type = Types.ContainerTypes.Valueable;
			else if (comboContainerType.Text == "Cooled")
				type = Types.ContainerTypes.Cooled;
			else
				type = Types.ContainerTypes.Regular;

			dock.AddContainer(ContainerFactory.GenereateSpecificContainer(weight, type, amount));

			VisualiseContainers();
		}
	}
}
