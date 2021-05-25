using Data_Layer.Users;
using Data_Layer.TemporaryData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_Layer.Manager
{
	public class UserManager
	{
		public TemporaryUserBuilder userBuilder = new TemporaryUserBuilder();
		public List<User> Users { get; set; }

		public UserManager()
		{
			Users = userBuilder.Users;
		}

		public User GetCustomerById(int id)
		{
			User user = Users[id + 1];
			return user;
		}

		public List<User> GetAllCustomers()
		{
			return Users;
		}

		public User EditCustomer(int id, User user)
		{
			Users[id + 1] = user;
			return Users[id + 1];
		}

		public User AddCustomer(User user)
		{
			Users.Add(user);
			return user;
		}

		public void RemoveCustomer(int id)
		{
			Users.RemoveAt(id + 1);
		}
	}
}
