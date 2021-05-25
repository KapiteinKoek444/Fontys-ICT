using Repository.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities.Connections
{
	public class OrderRule : EntityModelBase
	{
		public Guid OrderId { get; set; }
		public Guid PizzaId { get; set; }
	}
}
