using Repository.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Entities.Connections
{
	public class Order : EntityModelBase
	{
		public Guid UserId { get; set; }
		
		[ForeignKey("OrderId")]
		public virtual List<OrderRule> OrderRule { get; set; }
	}
}
