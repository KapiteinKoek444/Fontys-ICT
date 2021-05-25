using BusinessLogic.Manager.Pizza;
using BusinessLogic.Manager.PizzaComponents;
using BusinessLogic.Manager.User;
using BusinessLogic.Models;
using BusinessLogic.Models.IngredientComponents;
using BusinessLogic.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S2_Pizzaria.Controllers
{
	public class OrderController : Controller
	{
		public ActionResult PizzaBasePicker()
		{
			var models = PizzaManager.getAllPizzas();
			return View(models);
		}

		public ActionResult PickedPizza(Guid id)
		{
			var pizza = PizzaManager.GetPizza(id);
			OrderViewModel order = new OrderViewModel();
			order.pizza = pizza;
			TempData["order"] = order;
			return RedirectToAction("BottomPicker");
		}

		public ActionResult BottomPicker()
		{
			var models = BottomManager.GetAllBottoms();
			return View(models);
		}

		public ActionResult PickedBottom(Guid id)
		{
			var order = TempData["order"] as OrderViewModel;
			order.bottom = BottomManager.GetAllBottoms().Where(x => x.Id == id).FirstOrDefault();
			TempData["order"] = order;
			return RedirectToAction("SaucePicker");
		}

		public ActionResult SaucePicker()
		{
			var models = SauceManager.GetAllSauces();
			return View(models);
		}

		public ActionResult PickedSauce(Guid id)
		{
			var sauce = SauceManager.GetAllSauces().Where(x => x.Id == id).FirstOrDefault();

			var order = TempData["order"] as OrderViewModel;
			order.sauce = sauce;
			TempData["order"] = order;
			return RedirectToAction("IngredientsPicker");
		}

		public ActionResult IngredientsPicker()
		{
			var models = IngredientManager.GetIngredients();
			return View(models);
		}

		[HttpPost]
		public JsonResult SetIngredients(string[] data)
		{
			List<IngredientModel> ingredients = new List<IngredientModel>();
			foreach (var str in data)
			{
				var id = Guid.Parse(str);
				ingredients.Add(IngredientManager.GetIngredients().Where(x => x.Id == id).FirstOrDefault());
			}
			var order = TempData["order"] as OrderViewModel;
			order.ingredients = ingredients;
			TempData["order"] = order;
			return Json(new { redirectTo = Url.Action("AddOrder", "Order", order) });
		}

		public ActionResult AddOrder()
		{
			var id = new List<Guid>();
			var order = TempData["order"] as OrderViewModel;

			foreach (var i in order.ingredients)
			{
				id.Add(i.Id);
			}
			var cookie = HttpContext.User.Identity.Name;
			var orderviewmodel = PizzaManager.OrderPizza(Guid.Parse(cookie), order.pizza.Id, order.bottom.Id, order.sauce.Id, id);

			orderviewmodel.TotalPrice = orderviewmodel.ingredients.Sum(x => x.Price);
			orderviewmodel.TotalPrice += orderviewmodel.pizza.Price;
			orderviewmodel.TotalPrice += orderviewmodel.sauce.Price;
			orderviewmodel.TotalPrice += orderviewmodel.bottom.Price;

			TempData["order"] = orderviewmodel;
			return View(orderviewmodel);
		}

		public ActionResult OrderOrder()
		{
			var order = TempData["order"] as OrderViewModel;
			PizzaManager.OrderOrder(order);
			return RedirectToAction("Index", "Home");
		}
	}
}