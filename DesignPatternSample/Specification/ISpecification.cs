namespace DesignPatternSample.Specification
{
    interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}