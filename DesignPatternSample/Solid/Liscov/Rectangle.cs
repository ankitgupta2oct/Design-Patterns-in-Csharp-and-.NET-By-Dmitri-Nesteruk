namespace DesignPatternSample.Solid.Liscov
{
    class Rectangle
    {
        internal virtual int Height { set; get; }
        internal virtual int Width { set; get; }

        public Rectangle()
        { 
        }

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public override string ToString()
        {
            return $"{nameof(Height)} is {Height}, {nameof(Width)} is {Width}";
        }
    }
}