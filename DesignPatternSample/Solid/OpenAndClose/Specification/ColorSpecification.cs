namespace DesignPatternSample.Solid.OpenAndClose.Specification
{
    class ColorSpecification : ISpecification<Product>
    {
        Color _color;

        public ColorSpecification(Color color)
        {
            _color = color;
        }

        public bool IsSatisfied(Product product) => product.Color == _color;
    }
}
