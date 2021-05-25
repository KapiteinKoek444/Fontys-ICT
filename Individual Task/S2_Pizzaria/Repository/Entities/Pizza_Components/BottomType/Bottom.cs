using Repository.Entities.Base;
using Repository.Entities.Pizza_Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities.Pizza_Components.BottomType
{
	public class Bottom : EntityModelBase
	{
		public Guid SauceId { get; set; }

		public double Surface { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		public bool Thick { get; set; }
	}
}
