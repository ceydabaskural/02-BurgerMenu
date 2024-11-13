using _02_BurgerMenu.Context;
using _02_BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using Message = _02_BurgerMenu.Entities.Message;

namespace _02_BurgerMenu.Areas.Admin.Controllers
{
    [Authorize]
    public class MessageController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Inbox()
        {
            var userName = Session["x"];
            var email = context.Admins.Where(x => x.Username==userName).Select(x => x.Email).FirstOrDefault();
            var values= context.Messages.Where(x=>x.ReceiverEmail==email).ToList();
            return View(values);
        }
        public ActionResult Sentbox()
        {
            var userName = Session["x"];
            var email = context.Admins.Where(x => x.Username == userName).Select(x => x.Email).FirstOrDefault();
            var values = context.Messages.Where(x => x.SenderEmail == email).ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(Message message)
        {
            var userName = Session["x"];
            var email = context.Admins.Where(x => x.Username == userName).Select(x => x.Email).FirstOrDefault();
            message.SenderEmail = email;
            message.IsRead = false;
            message.SendDate = DateTime.Now;
            context.SaveChanges();
            return RedirectToAction("Sentbox", "Message", new { area = "Admin" });
        }

        public ActionResult MessageStatusChangeToTrue(int id)
        {
            var value = context.Messages.Where(x => x.MessageId == id).FirstOrDefault();
            value.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public ActionResult MessageStatusChangeToFalse(int id)
        {
            var value = context.Messages.Where(x => x.MessageId == id).FirstOrDefault();
            value.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public PartialViewResult PartialMessageDetail(int id)
        {
            var message = context.Messages.Find(id);

            return PartialView(message);
        }
    }
}