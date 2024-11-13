using _02_BurgerMenu.Context;
using _02_BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_BurgerMenu.Areas.Admin.Controllers
{
    public class AboutController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult AboutList()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }

        public ActionResult CreateAbout()
        {
            return View();
        }
        public ActionResult CreateAbout(About about)
        {
            context.Abouts.Add(about);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }

        public ActionResult DeleteAbout(int id)
        {
            var value = context.Abouts.Find(id);
            context.Abouts.Remove(value);
            context.SaveChanges();  
            return View(value);
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateAbout(About about)
        {
            var value = context.Abouts.Find(about.AboutId);
            value.Description = about.Description;
            value.ImageUrl = about.ImageUrl;
            value.SubTitle = about.SubTitle;
            value.Title = about.Title;
            value.MapLocation = about.MapLocation;
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}