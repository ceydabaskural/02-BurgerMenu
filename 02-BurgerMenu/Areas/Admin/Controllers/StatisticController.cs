using _02_BurgerMenu.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_BurgerMenu.Areas.Admin.Controllers
{
    public class StatisticController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult StatisticList()
        {
            ViewBag.Subsriber=context.Subscribers.Select(x => x.SubscriberId).Count();
            ViewBag.Product=context.Products.Select(x => x.ProductId).Count();
            ViewBag.Category=context.Categories.Select(x => x.CategoryId).Count();
            ViewBag.Login=context.Admins.Select(x => x.AdminId).Count();
            ViewBag.Referance=context.Testimonials.Select(x => x.TestimonialId).Count();
            ViewBag.Inbox=context.Messages.Select(x => x.ReceiverEmail).Count();
            ViewBag.Reservation=context.Reservations.Select(x => x.ReservationId).Count();
            ViewBag.ReservationStatus = context.Reservations.Where(x => x.ReservationStatus=="Onaylandı").Count();
            ViewBag.Gallery=context.Galleries.Select(x => x.GalleryId).Count();
            ViewBag.senderName = context.Messages.OrderByDescending(x => x.MessageId).Select(x=>x.SenderEmail).FirstOrDefault();
            ViewBag.messageIsRead=context.Messages.Where(x => x.IsRead==false).Count();
            return View();
        }
    }
}

