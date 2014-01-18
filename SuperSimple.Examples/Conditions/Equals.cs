namespace SuperSimple.Examples.Conditions
{
    using RulesEngine.Interfaces;

    internal class Equals : ICondition
    {
        private readonly int _actual;
        private readonly int _threshold;

        public Equals(int threshold, int actual)
        {
            _threshold = threshold;
            _actual = actual;
        }

        public bool IsSatisfied()
        {
            return _actual == _threshold;
        }
    }
}