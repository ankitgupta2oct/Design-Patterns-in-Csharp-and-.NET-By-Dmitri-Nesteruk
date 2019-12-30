namespace DesignPatternSample.Structural.Decorator.DynamicComposition
{
    abstract class Shape
    {
        public virtual string AsString() => string.Empty;
    }

    class Circle : Shape
    {
        private readonly float _radius;

        public Circle(float radius)
        {
            _radius = radius;
        }

        public override string AsString() => $"Circle shape with radius {_radius}";
    }

    class ColoredShape : Shape
    {
        private readonly Shape _shape;
        private readonly string _color;

        public ColoredShape(Shape shape, string color)
        {
            _shape = shape;
            _color = color;
        }

        public override string AsString() => $"{_shape.AsString()} and color {_color}";
    }

    class TransparentShape : Shape
    {
        private readonly Shape _shape;
        private readonly float _transparency;

        public TransparentShape(Shape shape, float transparency)
        {
            _shape = shape;
            _transparency = transparency;
        }

        public override string AsString() => $"{_shape.AsString()} and transparency {_transparency * 100}%";
    }

    class DynamicCompositionDemo
    {
        public DynamicCompositionDemo()
        {
            var circle = new Circle(2.5f);
            System.Console.WriteLine(circle.AsString());

            var redCircle = new ColoredShape(circle, "Red");
            System.Console.WriteLine(redCircle.AsString());

            var redTraparentCircle = new TransparentShape(redCircle, 0.5f);
            System.Console.WriteLine(redTraparentCircle.AsString());            

        }
    }
}
