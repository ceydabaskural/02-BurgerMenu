using _02_BurgerMenu.Context;
using _02_BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_BurgerMenu.Controllers
{
    public class DefaultController : Controller
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

        public PartialViewResult PartialAbout()
        {
            return PartialView();
        }

        public PartialViewResult PartialTodaysOffer()
        {
            var values = context.Products.Where(x => x.DealOfTheDay==true).ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialMenu()
        {
            var value = context.Products.ToList();
            return PartialView(value);
        }

        public PartialViewResult PartialCategory()
        {
            //Take metodu a'dan z'ye sıralayarak alır.
            var values = context.Categories.Take(6).ToList(); 
            return PartialView(values);
        }

        public PartialViewResult PartialGallery()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult PartialReservation()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialReservation(Reservation reservation)
        {
            reservation.ReservationStatus = "Onay Bekleniyor";
            reservation.PersonCount = 0;
            reservation.ReservationDate = DateTime.Now;
            context.Reservations.Add(reservation);
            context.SaveChanges();
            return PartialView();
        }


    }
}