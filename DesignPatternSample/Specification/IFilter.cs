using System.Collections.Generic;

namespace DesignPatternSample.Specification
{
    interface IFilter<T>
    {
        IEnumerable<T> GetFilteredData(IEnumerable<T> dataList, ISpecification<T> specification);
    }
}
