namespace DesignPatternSample.Solid.OpenAndClose.Specification
{
    class SizeSpecifation : ISpecification<Product>
    {
        Size _size;

        public SizeSpecifation(Size size)
        {
            _size = size;
        }

        public bool IsSatisfied(Product product) => product.Size == _size;
    }
}
