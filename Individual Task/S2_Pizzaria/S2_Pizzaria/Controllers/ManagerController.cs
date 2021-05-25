using BusinessLogic.Manager.Pizza;
using BusinessLogic.Manager.PizzaComponents;
using BusinessLogic.Models.IngredientComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S2_Pizzaria.Controllers
{
    public class ManagerController : Controller
    {
        //Ingredients
        [Authorize(Roles = "Employee")]
        public ActionResult ManageIngredients()
        {
            var ingredients = IngredientManager.GetIngredients();
            return View(ingredients);
        }

        [Authorize(Roles = "Employee")]
        public ActionResult AddIngredient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddIngredient(IngredientModel model)
        {
            IngredientManager.AddIngredient(model);
            return RedirectToAction("ManageIngredients");
        }

        [Authorize(Roles = "Employee")]
        public ActionResult IngredientDetails(IngredientModel model)
        {
            return View(model);
        }

        [Authorize(Roles = "Employee")]
        public ActionResult IngredientDelete(IngredientModel model)
        {
            IngredientManager.RemoveIngredient(model);
            return RedirectToAction("ManageIngredients");
        }
        //Pizzas
        [Authorize(Roles = "Employee")]
        public ActionResult ManagePizzas()
        {
            List<PizzaModel> models = PizzaManager.getAllPizzas();
            return View(models);
        }

        [Authorize(Roles = "Employee")]
        public ActionResult AddPizza()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPizza(PizzaModel model)
        {
            PizzaManager.AddPizza(model);
            return RedirectToAction("ManagePizzas");
        }

        [Authorize(Roles = "Employee")]
        public ActionResult PizzaDetails(PizzaModel model)
        {
            return View(model);
        }

        [Authorize(Roles = "Employee")]
        public ActionResult PizzaDelete(PizzaModel model)
        {
            PizzaManager.RemovePizza(model);
            return RedirectToAction("ManagePizzas");
        }

        //Bottoms
        [Authorize(Roles = "Employee")]
        public ActionResult ManageBottoms()
        {
            List<BottomModel> models = BottomManager.GetAllBottoms();
            return View(models);
        }

        [Authorize(Roles = "Employee")]
        public ActionResult AddBottom()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBottom(BottomModel model)
        {
            BottomManager.AddBottom(model);
            return RedirectToAction("ManageBottoms");
        }

        [Authorize(Roles = "Employee")]
        public ActionResult BottomDetails(BottomModel model)
        {
            return View(model);
        }

        [Authorize(Roles = "Employee")]
        public ActionResult BottomDelete(BottomModel model)
        {
            BottomManager.RemoveBottom(model);
            return RedirectToAction("ManageBottoms");
        }
        //Sauces
        [Authorize(Roles = "Employee")]
        public ActionResult ManageSauces()
        {
            List<SauceModel> models = SauceManager.GetAllSauces();
            return View(models);
        }

        [Authorize(Roles = "Employee")]
        public ActionResult AddSauce()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSauce(SauceModel model)
        {
            SauceManager.AddSauce(model);
            return RedirectToAction("ManageSauces");
        }

        [Authorize(Roles = "Employee")]
        public ActionResult SauceDetails(SauceModel model)
        {
            return View(model);
        }

        [Authorize(Roles = "Employee")]
        public ActionResult SauceDelete(SauceModel model)
        {
            SauceManager.RemoveSauce(model);
            return RedirectToAction("ManageSauces");
        }
    }
}