using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_BurgerMenu.Controllers
{
    public class ErrorPageController : Controller
    {
        // GET: Error
        public ActionResult Page404()
        {
            return View();
        }
    }
}