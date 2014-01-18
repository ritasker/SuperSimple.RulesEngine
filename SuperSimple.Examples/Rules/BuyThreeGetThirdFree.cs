namespace SuperSimple.Examples.Rules
{
    using System.Linq;
    using Conditions;

    public class BuyThreeGetThirdFree : BaseRule<ShoppingCart>
    {
        private readonly string _productName;

        public BuyThreeGetThirdFree(string productName)
        {
            _productName = productName;
        }

        public override void Initialize(ShoppingCart cart)
        {
            Conditions.Add(new Equals(3, cart.Products.Count(p => p.Name == _productName)));
        }

        public override ShoppingCart Apply(ShoppingCart cart)
        {
            cart.Products.Add(new Product {Name = "Discount", Price = -1.28m});
            return cart;
        }
    }
}