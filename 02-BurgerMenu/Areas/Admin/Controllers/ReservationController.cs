using _02_BurgerMenu.Context;
using _02_BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_BurgerMenu.Areas.Admin.Controllers
{
    public class ReservationController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult ReservationList()
        {
            var value = context.Reservations.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult UpdateReservation(int id)
        {
            var value = context.Reservations.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateReservation(Reservation reservation)
        {
            var value = context.Reservations.Find(reservation.ReservationId);
            value.Name = reservation.Name;
            value.Surname = reservation.Surname;
            value.Email = reservation.Email;
            value.Phone = reservation.Phone;
            value.PersonCount = reservation.PersonCount;
            value.ReservationDate = reservation.ReservationDate;
            value.Time = reservation.Time;
            value.Message = reservation.Message;
            value.ReservationStatus = reservation.ReservationStatus;
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }

        [HttpGet]
        public ActionResult CreateReservation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateReservation(Reservation reservation)
        {
            context.Reservations.Add(reservation);
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }

        public ActionResult ReservationStatusApproved(int id)
        {
            var value = context.Reservations.Where(x => x.ReservationId == id).FirstOrDefault();
            value.ReservationStatus = "Onaylandı";
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }

        public ActionResult ReservationStatusCancelled(int id)
        {
            var value = context.Reservations.Where(x => x.ReservationId == id).FirstOrDefault();
            value.ReservationStatus = "İptal Edildi";
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }

        public ActionResult ReservationStatusPending(int id)
        {
            var value = context.Reservations.Where(x => x.ReservationId == id).FirstOrDefault();
            value.ReservationStatus = "Onay Bekliyor";
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }
        public ActionResult ReservationStatusCompleted(int id)
        {
            var value = context.Reservations.Where(x => x.ReservationId == id).FirstOrDefault();
            value.ReservationStatus = "Tamamlandı";
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }

    }
}