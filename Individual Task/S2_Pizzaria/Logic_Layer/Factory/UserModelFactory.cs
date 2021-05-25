using Data_Layer.Entities.Users;
using Data_Layer.Users;
using Logic_Layer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_Layer.Factory
{
	public static class UserModelFactory
	{
		public static List<User> ConvertUser(List<UserModel> userModels)
		{
			List<User> users = new List<User>();

			foreach (var userModel in userModels)
			{
				var userMod = ConvertUser(userModel);
				users.Add(userMod);
			}
			return users;
		}

		public static User ConvertUser(UserModel cusModel)
		{
			User customer = new User(cusModel.UName, cusModel.Password, cusModel.Email, new Adress(cusModel.ZipCode, cusModel.HouseNr), cusModel.IsEmployee);
			return customer;
		}
	}
}
