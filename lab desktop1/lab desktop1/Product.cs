using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_desktop1
{
    internal class Product
    {
        public int Id { get; set; }
        public string Productname { get; set; }

        public double Price { get; set; }

        public Boolean IsAvailable { get; set; }


        public static List<Product> products = new List<Product>();
        public void Save()
        {
            products.Add(this);
        }
       public static List<Product> GetAllProducts()
        {
            return products;
        }
    };
        
       
}


