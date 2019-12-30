using System;

namespace DesignPatternSample.Structural.Decorator.MultipleInheritance
{
    class Bird : IBird
    {
        public int Weight { set; get; }

        public void Fly()
        {
            Console.WriteLine($"Fly with weight {Weight}");
        }
    }
}
