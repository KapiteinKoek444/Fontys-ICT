using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_Layer.Models
{
	public class UserModel
	{
		public string UName { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public string ZipCode { get; set; }
		public int HouseNr { get; set; }
		public bool IsEmployee { get; set; }
	}
}
