namespace SuperSimple.RulesEngine.Interfaces
{
    public interface IRule<T>
    {
        void ClearConditions();
        void Initialize(T objectToBeChecked);
        bool IsValid();
        T Apply(T objectToBeChecked);
    }
}
