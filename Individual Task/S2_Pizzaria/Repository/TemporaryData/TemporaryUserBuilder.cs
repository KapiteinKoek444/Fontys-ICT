using Repository.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.TemporaryData
{
	public class TemporaryUserBuilder
	{
		public List<User> Users = new List<User>();

		public TemporaryUserBuilder()
		{
			GenerateUser(1);
		}

		private void GenerateUser(int amount)
		{
			
		}
	}
}
