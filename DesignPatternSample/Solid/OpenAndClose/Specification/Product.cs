namespace DesignPatternSample.Solid.OpenAndClose.Specification
{
    class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }

        public override string ToString()
        {
            return $"Name : {Name}, Color : {Color}, Size : {Size}";
        }
    }

    enum Color { Green, Red, Blue }
    enum Size { Small, Large, Huge }
}
