using BusinessLogic.Models.Base;
using Repository.Entities.Connections;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
	public class UserModel : EntityModelBase
	{
		public OrderModel Order { get; set; }

		public string UName { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public string ZipCode { get; set; }
		public int HouseNr { get; set; }
		public bool IsEmployee { get; set; }
	}
}
