namespace SuperSimple.Examples.Rules
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using RulesEngine.Interfaces;

    public abstract class BaseRule<ShoppingCart> : IRule<ShoppingCart>
    {
        protected BaseRule()
        {
            Conditions = new List<ICondition>();
        }

        public IList<ICondition> Conditions { get; set; }

        public void ClearConditions()
        {
            Conditions.Clear();
        }

        public bool IsValid()
        {
            return Conditions.All(x => x.IsSatisfied());
        }

        public virtual void Initialize(ShoppingCart obj)
        {
            throw new NotImplementedException();
        }

        public virtual ShoppingCart Apply(ShoppingCart obj)
        {
            throw new NotImplementedException();
        }
    }
}