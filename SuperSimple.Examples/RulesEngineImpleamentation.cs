namespace SuperSimple.Examples
{
    using Rules;
    using RulesEngine;

    public class RulesEngineImpleamentation
    {
        private readonly ShoppingCart _shoppingCart;

        public RulesEngineImpleamentation(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public ShoppingCart Run()
        {
            _shoppingCart
                .ApplyRule(new BuyThreeGetThirdFree("Widget"))
                .ApplyRule(new FreeShipping());

            return _shoppingCart;
        }
    }
}