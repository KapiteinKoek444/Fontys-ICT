using BusinessLogic.Models;
using BusinessLogic.Factory;
using System;
using System.Linq;
using Repository.UnitOfWork;
using System.Collections.Generic;

namespace BusinessLogic.Manager.User
{
	public static class UserManager
	{
		public static void RemoveUser(UserModel model)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var user = UserFactory.ConvertUser(model);
			unitOfWork.UserRepository.RemoveUser(user.Id);
		}

		public static UserModel AddUser(UserModel model)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var user = UserFactory.ConvertUser(model);
			user.Id = Guid.NewGuid();
			unitOfWork.UserRepository.AddUser(user);
			return model;
		}

		public static List<UserModel> GetUsers()
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var users = unitOfWork.UserRepository.GetUsers();
			var models = UserModelFactory.ConvertUsers(users);
			return models;
		}

		public static UserModel GetUser(string username, string password)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var user = unitOfWork.UserRepository.GetUser(username, password);
			var model = UserModelFactory.ConvertUser(user);
			return model;
		}

		public static UserModel GetUserById(Guid Id)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var user = unitOfWork.UserRepository.GetUserId(Id);
			var model = UserModelFactory.ConvertUser(user);
			return model;
		}

		public static string ReturnRole(Guid guid)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var user = unitOfWork.UserRepository.GetUserId(guid);
			if (user == null)
				return "";

			if (user.IsEmployee)
				return "Employee";
			else
				return "Customer";
		}

		public static UserModel UpdateUser(UserModel model)
		{
			UnitOfWorkRepository unitOfWork = new UnitOfWorkRepository();
			var user = UserFactory.ConvertUser(model);
			unitOfWork.UserRepository.UpdateUser(user);
			return model;
		}
	}
}
