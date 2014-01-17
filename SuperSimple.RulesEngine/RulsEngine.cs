namespace SuperSimple.RulesEngine
{
    using SuperSimple.RulesEngine.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class RulesEngine
    {
        public static T ApplyRules<T>(this T obj, List<IRule<T>> rules) where T : class
        {
            foreach (var rule in rules)
            {
                obj.ApplyRule(rule);
            }
            return obj;
        }

        public static T ApplyRule<T>(this T obj, IRule<T> rule) where T : class
        {
            rule.ClearConditions();
            rule.Initialize(obj);
            if (rule.IsValid())
            {
                rule.Apply(obj);
            }
            return obj;
        }
    }
}
