namespace DesignPatternSample.Creational.Factory
{
    partial class Person
    {
        public double x, y;

        public Person(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{nameof(x)} : {x}, {nameof(y)} : {y}";
        }
    }
}
