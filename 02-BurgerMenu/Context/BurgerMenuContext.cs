using _02_BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _02_BurgerMenu.Context
{
    //context: c# da bulunan verilerimizi sql e tablo olarak gönderecek
    public class BurgerMenuContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<DealOfTheDay> DealOfTheDays { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Admin> Admins { get; set; } 
        public DbSet<Reservation> Reservations { get; set; } 
        public DbSet<Message> Messages { get; set; } 
        public DbSet<Gallery> Galleries { get; set; } 
        public DbSet<Contact> Contacts { get; set; } 
        public DbSet<About> Abouts { get; set; } 
        public DbSet<Subscriber> Subscribers { get; set; } 
    }
}