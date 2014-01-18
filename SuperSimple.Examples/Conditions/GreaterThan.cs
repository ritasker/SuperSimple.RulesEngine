namespace SuperSimple.Examples.Conditions
{
    using RulesEngine.Interfaces;

    public class GreaterThan : ICondition
    {
        private readonly decimal _actual;
        private readonly decimal _threshold;

        public GreaterThan(decimal threshold, decimal actual)
        {
            _threshold = threshold;
            _actual = actual;
        }

        public bool IsSatisfied()
        {
            return _actual > _threshold;
        }
    }
}