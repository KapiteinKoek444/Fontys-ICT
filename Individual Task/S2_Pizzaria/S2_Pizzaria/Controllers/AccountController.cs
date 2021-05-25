using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BusinessLogic.Manager.User;
using BusinessLogic.Models;

namespace S2_Pizzaria.Controllers
{
	public class AccountController : Controller
	{
		public ActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Login(LoginModel customer)
		{
			var user = UserManager.GetUser(customer.Uname, customer.Password);
			if (user == null)
				return View();

			FormsAuthentication.SetAuthCookie(user.Id.ToString(), false);
			return RedirectToAction("Index", "Home");
		}

		public ActionResult RegisterUser()
		{
			return View();
		}

		[HttpPost]
		public ActionResult RegisterUser(UserModel userModel)
		{
			userModel.IsEmployee = false;
			var user = UserManager.AddUser(userModel);
			if (user == null)
				return View();

			FormsAuthentication.SetAuthCookie(user.Id.ToString(), false);
			return RedirectToAction("Index", "Home");
		}

		public ActionResult Manage(UserModel model)
		{
			if(model.UName == null)
			{
				var cookie = HttpContext.User.Identity.Name;
				var user = UserManager.GetUserById(Guid.Parse(cookie));
				return View(user);
			}

			return View(model);
		}

		public ActionResult EditUser()
		{
			return View();
		}

		[HttpPost]
		public ActionResult EditUser(UserModel model)
		{
			var user = UserManager.UpdateUser(model);
			return View("Manage", user);
		}

		public ActionResult ChangePassword()
		{
			return View();
		}
	}
}