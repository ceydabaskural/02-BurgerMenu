using _02_BurgerMenu.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_BurgerMenu.Areas.Admin.Controllers
{

    [Authorize]
    public class ProfileController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();

        public ActionResult MyProfileList()
        {
            var userName=Session["x"]; //eğer kullanıcı doğru bir şekilde login olursa, kullanıcı adını Session["x"] içine atamıştık. Şimdi onu burda yine kullanıyoruz
            var values = context.Admins.Where(x => x.Username == userName).FirstOrDefault(); //bu bize giriş yapan kullanıcının bilgilerini getirecek

            return View(values);
        }

        [HttpPost]
        public ActionResult MyProfileList(_02_BurgerMenu.Entities.Admin admin)
        {
            //update işlemi:

            var userName = Session["x"];
            var values = context.Admins.Where(x => x.Username == userName).FirstOrDefault();
            values.Username= admin.Username;
            values.Surname= admin.Surname;
            values.Name= admin.Name;
            values.Password= admin.Password;
            values.Email= admin.Email;
            context.SaveChanges();

            return RedirectToAction("Index", "Login"); //temel bilgileri değiştirdikten sonra tekrar login olmasını istediğimiz için Login sayfasına yönlendirdik
        }
    }
}