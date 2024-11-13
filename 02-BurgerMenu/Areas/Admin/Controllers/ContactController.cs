using _02_BurgerMenu.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_BurgerMenu.Areas.Admin.Controllers
{
    public class ContactController : Controller
    {
        BurgerMenuContext context= new BurgerMenuContext();
        public ActionResult ContactList()
        {
            var value = context.Contacts.ToList();
            return View(value);
        }
    }
}