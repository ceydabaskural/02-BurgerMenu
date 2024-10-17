using _02_BurgerMenu.Context;
using _02_BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace _02_BurgerMenu.Controllers
{
    public class LoginController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var values = context.Admins.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);

            if (values != null)
            {
                //oturum açma kodları:                
                FormsAuthentication.SetAuthCookie(values.Username, false); //false diyerek username in arka planda kaydedilmemesini sağladık
                Session["x"] = values.Username.ToString(); //username i string olarak tutulmasını istedik ve bunu Session["x"] e atadık
                return RedirectToAction("ProductList", "Product", new { area = "Admin" });
            }
            else
            {
                return View();
            }

        }
    }
}