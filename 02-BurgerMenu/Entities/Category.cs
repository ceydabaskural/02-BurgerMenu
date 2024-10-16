using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _02_BurgerMenu.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }


        //Bireçok ilişki

        //Bize ürünleri liste halinde getirir
        public List<Product> Products { get; set; }
    }
}