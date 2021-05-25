using Repository.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Users
{
	public class User : EntityModelBase
	{
		public Guid OrderId { get; set; }

		public string UName { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public string ZipCode { get; set; }
		public int HousNr { get; set; }
		public bool IsEmployee { get; set; }
	}
}
