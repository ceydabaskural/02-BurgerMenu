using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _02_BurgerMenu.Entities
{
    public class Product
    {
        public int ProductId { get; set; }

        [StringLength(100)] //eğer bunu yazmassak sql tarafında nvarchar(Max) olarak alır
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }



        //Birebir ilişki

        //her ürünün bir kategorisi olduğu için categoryid ekledik
        public int CategoryId { get; set; }
        //categoryid sini ekldiğimiz ürünün ismini çekmek için de Category sınıfından bir category property si oluşturduk. 
        //virtual olarak eklediğimizde bu bizim tablomuzun içine eklenmemiş olacak (aslında soyut bir ifade oluşturdu), amaç 'Category' sınıfı üzerinden category nin ögelerine erişmektir.
        public virtual Category Category { get; set; }
    }
}