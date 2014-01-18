namespace SuperSimple.Examples
{
    using System.Collections.Generic;
    using System.Linq;

    public class ShoppingCart
    {
        public ShoppingCart()
        {
            Products = new List<Product>();
        }

        public bool FreeShippng { get; set; }
        public IList<Product> Products { get; set; }

        public decimal TotalValue
        {
            get { return Products.Sum(p => p.Price); }
        }
    }
}