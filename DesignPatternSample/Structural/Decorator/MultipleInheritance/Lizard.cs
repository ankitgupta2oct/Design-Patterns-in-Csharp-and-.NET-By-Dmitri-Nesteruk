using System;

namespace DesignPatternSample.Structural.Decorator.MultipleInheritance
{
    class Lizard : ILizard
    {
        public int Weight { set; get; }

        public void Crawl()
        {
            Console.WriteLine($"Crawl with weight {Weight}");
        }
    }
}
