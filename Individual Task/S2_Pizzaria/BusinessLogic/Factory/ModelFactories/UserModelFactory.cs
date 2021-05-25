using Repository.Users;
using BusinessLogic.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using Repository.UnitOfWork;
using BusinessLogic.Factory.ModelFactories;

namespace BusinessLogic.Factory
{
	public static class UserModelFactory
	{
		public static List<UserModel> ConvertUsers(List<User> users)
		{
			List<UserModel> userModels = new List<UserModel>();

			foreach (var user in users)
			{
				var userMod = ConvertUser(user);
				userModels.Add(userMod);
			}
			return userModels;
		}

		public static UserModel ConvertUser(User user)
		{
			if (user == null)
				return null;
			var order = OrderModelFactory.GetOrderModel(user.OrderId);
			UserModel customerMod = new UserModel
			{
				Id = user.Id,
				UName = user.UName,
				Password = user.Password,
				Email = user.Email,
				ZipCode = user.ZipCode,
				HouseNr = user.HousNr,
				IsEmployee = user.IsEmployee,
				Order = order
			};

			return customerMod;
		}

		public static UserModel GetUserModel(Guid Id)
		{
			UnitOfWorkRepository unitofwork = new UnitOfWorkRepository();
			var user = unitofwork.UserRepository.GetUserId(Id);
			var model = ConvertUser(user);
			return model;
		}
	}
}
