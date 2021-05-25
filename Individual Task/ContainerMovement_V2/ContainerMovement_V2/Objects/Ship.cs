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

namespace ContainerMovement_V2.Objects
{
	public class Ship
	{
		public readonly List<Stack> piles = new List<Stack>();
		public readonly bool IsEven = false;

		public Size Size { get; set; }

		public int MaxWeight { get; set; }
		public int Weight { get; set; }

		public int LeftWeight { get; set; }
		public int RightWeight { get; set; }

		public Ship(Size size, int maxWeight)
		{
			Size = size;
			MaxWeight = maxWeight;


			//Adding 
			for (int i = 0; i < Size.Width; i++)
			{
				for (int j = 0; j < Size.Height; j++)
				{
					Stack pile = new Stack(new Point(i, j));
					piles.Add(pile);
				}
			}

			if (Size.Height % 2 == 0)
				IsEven = true;
		}

		public bool AddCooledContainer(ShipContainer c, Types.Sides side)
		{

			foreach (var pile in piles)
			{
				Point point = pile.Location;
				if (IsEven)
				{
					if (side == Types.Sides.Left)
						if (point.X == 0 && point.Y + 1 <= Size.Height / 2)
							if (CheckForValueables(pile))
								if (pile.AddContainer(c))
									return true;

					if (side == Types.Sides.Right)
						if (point.X == 0 && point.Y + 1 > Size.Height / 2)
							if (CheckForValueables(pile))
								if (pile.AddContainer(c))
									return true;
				}
				else
				{
					if (side == Types.Sides.Left)
						if (point.X == 0 && point.Y + 1 <= Size.Height / 2)
							if (CheckForValueables(pile))
								if (pile.AddContainer(c))
									return true;

					if (side == Types.Sides.Right)
						if (point.X == 0 && point.Y + 1 > (Size.Height / 2) + 1)
							if (CheckForValueables(pile))
								if (pile.AddContainer(c))
									return true;

					if (side == Types.Sides.Middle)
						if (point.X == 0 && point.Y + 1 == (Size.Height / 2) + 1)
							if (CheckForValueables(pile))
								if (pile.AddContainer(c))
									return true;
				}
			}
			return false;
		}

		public bool AddValueableContainer(ShipContainer c, Types.Sides side)
		{
			foreach (var pile in piles)
			{
				Point point = pile.Location;
				if (IsEven)
				{
					if (side == Types.Sides.Left)
						if (point.Y + 1 <= Size.Height / 2)
							if (CheckForValueables(pile))
								if (CheckAccesable(point))
									if (pile.AddContainer(c))
										return true;

					if (side == Types.Sides.Right)
						if (point.Y + 1 > Size.Height / 2)
							if (CheckForValueables(pile))
								if (CheckAccesable(point))
									if (pile.AddContainer(c))
										return true;
				}
				else
				{
					if (side == Types.Sides.Left)
						if (point.Y + 1 <= Size.Height / 2)
							if (CheckForValueables(pile))
								if (CheckAccesable(point))
									if (pile.AddContainer(c))
										return true;

					if (side == Types.Sides.Right)
						if (point.Y + 1 > (Size.Height / 2) + 1)
							if (CheckForValueables(pile))
								if (CheckAccesable(point))
									if (pile.AddContainer(c))
										return true;

					if (side == Types.Sides.Middle)
						if (point.Y + 1 == (Size.Height / 2) + 1)
							if (CheckForValueables(pile))
								if (CheckAccesable(point))
									if (pile.AddContainer(c))
										return true;
				}
			}
			return false;
		}

		public bool AddRegularContainer(ShipContainer c, Types.Sides side)
		{
			foreach (var pile in piles)
			{
				Point point = pile.Location;
				if (IsEven)
				{
					if (side == Types.Sides.Left)
						if (point.Y + 1 <= Size.Height / 2)
							if (CheckForValueables(pile))
								if (pile.AddContainer(c))
									return true;

					if (side == Types.Sides.Right)
						if (point.Y + 1 > Size.Height / 2)
							if (CheckForValueables(pile))
								if (pile.AddContainer(c))
									return true;
				}
				else
				{
					if (side == Types.Sides.Left)
						if (point.Y + 1 <= Size.Height / 2)
							if (CheckForValueables(pile))
								if (pile.AddContainer(c))
									return true;

					if (side == Types.Sides.Right)
						if (point.Y + 1 > (Size.Height / 2) + 1)
							if (CheckForValueables(pile))
								if (pile.AddContainer(c))
									return true;

					if (side == Types.Sides.Middle)
						if (point.Y + 1 == (Size.Height / 2) + 1)
							if (CheckForValueables(pile))
								if (pile.AddContainer(c))
									return true;
				}
			}
			return false;
		}

		public bool CheckOccupation(Point point)
		{
			if (piles.Where(x => x.Location == point).Any())
				return false;

			return true;
		}

		public Types.Sides CheckBalance(bool endCheck)
		{
			LeftWeight = 0;
			RightWeight = 0;
			Weight = 0;

			decimal side;

			if (IsEven)
			{
				side = Size.Height / 2;
				foreach (var stack in piles)
				{
					if (stack.Location.Y + 1 > side)
						LeftWeight += stack.getWeight();

					else if (stack.Location.Y + 1 <= side)
						RightWeight += stack.getWeight();

					Weight += stack.getWeight();
				}

			}
			else
			{
				side = ((Size.Height - 1) / 2) + 1;
				foreach (var stack in piles)
				{
					if (stack.Location.Y + 1 > side)
						LeftWeight += stack.getWeight();

					if (stack.Location.Y + 1 < side)
						RightWeight += stack.getWeight();

					Weight += stack.getWeight();
				}

			}

			if (LeftWeight >= RightWeight * 1.1)
				return Types.Sides.Left;

			if (RightWeight >= LeftWeight * 1.1)
				return Types.Sides.Right;

			if (endCheck)
				return Types.Sides.End;

			if (!IsEven)
				return Types.Sides.Middle;

			return Types.Sides.Left;
		}

		public bool CheckForValueables(Stack pile)
		{
			if (pile.containers.Any(x => x.Type == Types.ContainerTypes.Valueable))
				return false;

			return true;
		}

		public bool CheckAccesable(Point point)
		{
			int chanses = 0;

			foreach (var pile in piles.Where(x => x.Location.X == point.X - 1 || x.Location.X == point.X + 1).ToList())
			{
				if (pile.height > piles.Where(x => x.Location.X == point.X).FirstOrDefault().height)
					chanses++;

				if (chanses > 1)
					return false;
			}

			return true;
		}
	}
}
