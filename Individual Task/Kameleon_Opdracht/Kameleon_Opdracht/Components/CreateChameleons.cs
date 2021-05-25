using Kameleon_Opdracht.Components.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kameleon_Opdracht.Components
{
	public class CreateChameleons
	{

		public static List<Chameleon> GenerateChameleons(int red, int blue, int green)
		{
			Random rnd = new Random();

			List<Chameleon> chameleons = new List<Chameleon>();

			for (int r = 0; r < red; r++)
			{
				Point speed = new Point(rnd.Next(1, 4), rnd.Next(1, 4));
				Chameleon chameleonRed = new Chameleon(new Size(20,20),ChameleonTypes.Colors.Red,new Point(rnd.Next(1, 700 - 21), rnd.Next(1, 600 - 21)), speed);
				chameleons.Add(chameleonRed);
			}

			for (int b = 0; b < blue; b++)
			{
				Point speed = new Point(rnd.Next(1, 4), rnd.Next(1, 4));
				Chameleon chameleonBlue = new Chameleon(new Size(20, 20), ChameleonTypes.Colors.Blue, new Point(rnd.Next(1, 700 - 21), rnd.Next(1, 600 - 21)), speed);
				chameleons.Add(chameleonBlue);
			}

			for (int g = 0; g < green; g++)
			{
				Point speed = new Point(rnd.Next(1, 4), rnd.Next(1, 4));
				Chameleon chameleonGreen = new Chameleon(new Size(20, 20), ChameleonTypes.Colors.Green, new Point(rnd.Next(1, 700 - 21), rnd.Next(1, 600 - 21)), speed);
				chameleons.Add(chameleonGreen);
			}

			return chameleons;
		}
	}
}
