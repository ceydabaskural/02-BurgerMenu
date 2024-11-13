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
        public PartialViewResult PartialAboutDetail()
        {
            var value = context.Abouts.ToList();
            return PartialView(value);
        }

        public PartialViewResult PartialTodaysOffer()
        {
            var values = context.Products.Where(x => x.DealOfTheDay == true).ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialMenu()
        {
            var value = context.Products.ToList();
            return PartialView("PartialMenu", value);
        }

        
        public PartialViewResult PartialCategory()
        {
            var values = context.Categories.Take(10).ToList();
            return PartialView("PartialCategory",values);
        }

        public PartialViewResult PartialCategoryDetail(int id)
        {
            var value = context.Products.Where(p => p.CategoryId == id).ToList();
            return PartialView(value);
        }

        public PartialViewResult PartialGallery()
        {
            var value = context.Galleries.ToList();
            return PartialView(value);
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

        [HttpGet]
        public PartialViewResult PartialContact()
        {
            ViewBag.MapLocation = context.Abouts.Select(a => a.MapLocation).FirstOrDefault();
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialContact(Contact contact)
        {
            context.Contacts.Add(contact);
            context.SaveChanges();
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult PartialSubscription()
        {
            var value = context.Subscribers.ToList();
            return PartialView(value);
        }

        [HttpPost]
        public PartialViewResult PartialSubscription(Subscriber subscriber)
        {
            context.Subscribers.Add(subscriber);
            context.SaveChanges();
            return PartialView();
        }

    }
}