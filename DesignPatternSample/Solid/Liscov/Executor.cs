using System;

namespace DesignPatternSample.Solid.Liscov
{
    class Executor
    {
        public Executor()
        {
            Rectangle rectangle = new Square();
            rectangle.Width = 2;
            Console.WriteLine($"Rectangle {rectangle} has Area : {GetArea(rectangle)}");
        }

        int GetArea(Rectangle rectangle)
        {
            return rectangle.Height * rectangle.Width;
        }
    }
}