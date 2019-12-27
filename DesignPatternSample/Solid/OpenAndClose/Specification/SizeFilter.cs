using System.Collections.Generic;

namespace DesignPatternSample.Solid.OpenAndClose.Specification
{
    class SizeFilter : IFilter<Product>
    {
        public IEnumerable<Product> GetFilteredData(IEnumerable<Product> dataList, ISpecification<Product> specification)
        {
            foreach (var item in dataList)
                if (specification.IsSatisfied(item))
                    yield return item;
        }
    }
}
