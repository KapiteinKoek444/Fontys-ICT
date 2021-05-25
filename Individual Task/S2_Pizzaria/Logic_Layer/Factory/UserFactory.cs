using Data_Layer.Users;
using Logic_Layer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_Layer.Factory
{
	public static class UserFactory
	{
		public static List<UserModel> ConvertUser(List<User> users)
		{
			List<UserModel> userModels = new List<UserModel>();
			//Database connectie

			foreach (var user in users)
			{
				var userMod = ConvertUser(user);
				userModels.Add(userMod);
			}
			return userModels;
		}

		public static UserModel ConvertUser(User user)
		{
			UserModel customerMod = new UserModel
			{
				UName = user.UName,
				Password = user.Password,
				Email = user.Email,
				ZipCode = user.Adress.ZipCode,
				HouseNr = user.Adress.HousNr,
				
			};

			return customerMod;
		}
	}
}
