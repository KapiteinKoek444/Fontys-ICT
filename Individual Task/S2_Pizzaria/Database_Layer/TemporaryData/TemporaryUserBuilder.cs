using Data_Layer.Entities.Users;
using Data_Layer.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Layer.TemporaryData
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
			for (int i = 0; i < amount; i++)
			{
				User user = new User("Jeroen", "wachtwoordjuu", "jeroen@test.test", new Adress("5658ED", 4), false);
				Users.Add(user);
			}
		}
	}
}
