using System.Collections.Generic;

namespace DesignPatternSample.Solid.OpenAndClose.Specification
{
    interface IFilter<T>
    {
        IEnumerable<T> GetFilteredData(IEnumerable<T> dataList, ISpecification<T> specification);
    }
}
