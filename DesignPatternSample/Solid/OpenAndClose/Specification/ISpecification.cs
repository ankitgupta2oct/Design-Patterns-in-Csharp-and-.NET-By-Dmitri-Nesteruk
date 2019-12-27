namespace DesignPatternSample.Solid.OpenAndClose.Specification
{
    interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}