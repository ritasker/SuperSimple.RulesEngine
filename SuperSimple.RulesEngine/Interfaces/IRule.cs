namespace SuperSimple.RulesEngine.Interfaces
{
    public interface IRule<T>
    {
        void ClearConditions();
        void Initialize(T obj);
        bool IsValid();
        T Apply(T obj);
    }
}