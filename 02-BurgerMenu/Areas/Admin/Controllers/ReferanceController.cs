using _02_BurgerMenu.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_BurgerMenu.Areas.Admin.Controllers
{
    public class ReferanceController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult ReferanceList()
        {
            var value = context.Testimonials.ToList();
            return View(value);
        }

        public ActionResult Delete(int id)
        {
            var value = context.Testimonials.Find(id);
            context.Testimonials.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ReferanceList");
        }
    }
}