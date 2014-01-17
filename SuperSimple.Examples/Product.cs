using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSimple.Examples
{
    public class ShoppingCart
    {
        public ShoppingCart()
	    {
            Products = new List<Product>();
	    }

        public IList<Product>() Products { get; }
        public decimal TotalValue 
        { 
            get { return Products.Sum(p => p.Price);} 
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
