using Kameleon_Opdracht.Components.Enums;
using System.Drawing;
using System.Windows.Forms;

namespace Kameleon_Opdracht.Components
{
	public class Chameleon
	{
		public Size Size { get; set; }
		public ChameleonTypes.Colors Color { get; set; }
		public Point Location { get; set; }
		public Point Speed { get; set; }

		public Chameleon(Size size, ChameleonTypes.Colors color, Point location, Point speed)
		{
			Size = size;
			Color = color;
			Location = location;
			Speed = speed;
		}

		public void MoveLocation()
		{
			Location = new Point(Location.X + Speed.X, Location.Y + Speed.Y);
		}

		public void CheckBorders(Panel Island)
		{
			if (Location.X + Size.Width >= Island.Width || Location.X <= 0)
				Speed = new Point(Speed.X * -1, Speed.Y);
			
			if (Location.Y + Size.Height >= Island.Height || Location.Y <= 0)
				Speed = new Point(Speed.X, Speed.Y * -1);
		}

		public void ColorCheck(Chameleon partner)
		{
			for (int xC = 0; xC < Size.Width; xC++)
			{
				int ChameleonWidth = xC + Location.X;
				if (ChameleonWidth > partner.Location.X
					&& ChameleonWidth < partner.Location.X + partner.Size.Width
					&& Location.Y < partner.Location.Y + partner.Size.Height
					&& Location.Y + Size.Height > partner.Location.Y)
				{
					if(Color == ChameleonTypes.Colors.Red && partner.Color == ChameleonTypes.Colors.Blue
						|| Color == ChameleonTypes.Colors.Blue && partner.Color == ChameleonTypes.Colors.Red)
					{
						Color = ChameleonTypes.Colors.Green;
						partner.Color = ChameleonTypes.Colors.Green;
					}
					else if(Color == ChameleonTypes.Colors.Green && partner.Color == ChameleonTypes.Colors.Blue
						|| Color == ChameleonTypes.Colors.Blue && partner.Color == ChameleonTypes.Colors.Green)
					{
						Color = ChameleonTypes.Colors.Red;
						partner.Color = ChameleonTypes.Colors.Red;
					}
					else if(Color == ChameleonTypes.Colors.Red && partner.Color == ChameleonTypes.Colors.Green
						|| Color == ChameleonTypes.Colors.Green && partner.Color == ChameleonTypes.Colors.Red)
					{
						Color = ChameleonTypes.Colors.Blue;
						partner.Color = ChameleonTypes.Colors.Blue;
					}

					Speed = new Point(Speed.X * -1, Speed.Y * -1);
					partner.Speed = new Point(partner.Speed.X * -1, partner.Speed.Y * -1);
				}
			}
		}
	}
}
