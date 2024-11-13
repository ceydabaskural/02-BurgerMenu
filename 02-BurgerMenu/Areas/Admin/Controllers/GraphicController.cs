using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_BurgerMenu.Areas.Admin.Controllers
{
    public class GraphicController : Controller
    {
        // GET: Admin/Graphic
        public ActionResult GraphicList()
        {
            return View();
        }
    }
}