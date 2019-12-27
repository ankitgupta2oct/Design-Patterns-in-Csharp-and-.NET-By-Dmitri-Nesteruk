namespace DesignPatternSample.Solid.OpenAndClose.Specification
{
    class ColorAndSizeSpecification : ISpecification<Product>
    {
        Size _size;
        Color _color;

        public ColorAndSizeSpecification(Size size, Color color)
        {
            _size = size;
            _color = color;
        }

        public bool IsSatisfied(Product product) => product.Color == _color && product.Size == _size;
    }
}
