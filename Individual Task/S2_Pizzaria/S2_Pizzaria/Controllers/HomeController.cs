using BusinessLogic.Manager.Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S2_Pizzaria.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult ViewPizzas()
		{
			var pizzas = PizzaManager.getAllPizzas();
			return View(pizzas);
		}

		public ActionResult About()
		{
			return View();
		}

		public ActionResult Contact()
		{
			return View();
		}

		public ActionResult ManagerChooser()
		{
			return View();
		}
	}
}