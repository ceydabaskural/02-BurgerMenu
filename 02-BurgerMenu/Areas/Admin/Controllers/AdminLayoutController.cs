using _02_BurgerMenu.Context;
using _02_BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_BurgerMenu.Areas.Admin.Controllers
{
    public class AdminLayoutController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult PartialCategoryAdd()
        {
            return PartialView();
        }


        [HttpPost]
        public PartialViewResult PartialCategoryAdd(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return PartialView();
        }
    }
}