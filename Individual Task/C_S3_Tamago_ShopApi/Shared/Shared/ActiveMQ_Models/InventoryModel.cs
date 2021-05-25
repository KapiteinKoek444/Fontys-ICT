using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.Shared.ActiveMQ_Models
{
	public class InventoryModel
	{ 
		public Guid id { get; set; }
		public Guid userId { get; set; }
		public List<Guid> itemId { get; set; }
	}
}
