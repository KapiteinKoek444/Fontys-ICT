using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Data_Layer.Entities.Users
{
	public class Adress
	{
		public string ZipCode { get; set; }
		public int HousNr { get; set; }

		public Adress(string zipCode, int houseNr)
		{
			ZipCode = zipCode;
			HousNr = houseNr;
		}
	}
}
