namespace SuperSimple.Examples.Rules
{
    using Conditions;

    public class FreeShipping : BaseRule<ShoppingCart>
    {
        public override void Initialize(ShoppingCart obj)
        {
            Conditions.Add(new GreaterThan(10.24m, obj.TotalValue));
        }

        public override ShoppingCart Apply(ShoppingCart obj)
        {
            obj.FreeShippng = true;
            return obj;
        }
    }
}