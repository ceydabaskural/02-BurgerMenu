using _02_BurgerMenu.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_BurgerMenu.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult DashboardList()
        {
            ViewBag.testimonial = context.Testimonials.Select(x=> x.TestimonialId).Count();
            ViewBag.subscriberCount = context.Subscribers.Select(x=> x.SubscriberId).Count();
            ViewBag.productCount = context.Products.Select(x => x.ProductId).Count();
            ViewBag.reservationCount = context.Reservations.Select(x => x.ReservationId).Count();
            ViewBag.dealOfPrice = context.DealOfTheDays.Select(x => x.Price).FirstOrDefault();
            ViewBag.productPrice = context.Products.Select(x => x.Price).ToList();
            ViewBag.productCategory = context.Products.Select(x => x.Category.CategoryName).ToList();
            ViewBag.productName = context.Products.Select(x => x.ProductName).ToList();
            ViewBag.products = context.Products.ToList();


            return View();
        }
    }
}