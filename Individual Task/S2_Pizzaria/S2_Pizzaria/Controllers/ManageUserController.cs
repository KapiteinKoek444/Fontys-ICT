using BusinessLogic.Manager.User;
using BusinessLogic.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S2_Pizzaria.Controllers
{
	public class ManageUserController : Controller
	{
		[Authorize(Roles = "Employee")]
		public ActionResult ManageUsers()
		{
			var users = UserManager.GetUsers();
			return View(users);
		}

		[Authorize(Roles = "Employee")]
		public ActionResult AddUser()
		{
			return View();
		}

		[HttpPost]
		public ActionResult AddUser(UserModel model)
		{
			UserManager.AddUser(model);
			return RedirectToAction("ManageUsers");
		}

		[Authorize(Roles = "Employee")]
		public ActionResult UserDetails(Guid Id)
		{
			var model = UserManager.GetUserById(Id);
			return View(model);
		}

		[Authorize(Roles = "Employee")]
		public ActionResult UserDelete(Guid Id)
		{
			var model = UserManager.GetUserById(Id);
			return View(model);
		}

		[HttpPost]
		public ActionResult UserDelete(Guid Id, UserModel model)
		{
			if (model.UName == null)
				model = UserManager.GetUserById(Id);

			UserManager.RemoveUser(model);
			return RedirectToAction("ManageUsers");
		}
	}
}