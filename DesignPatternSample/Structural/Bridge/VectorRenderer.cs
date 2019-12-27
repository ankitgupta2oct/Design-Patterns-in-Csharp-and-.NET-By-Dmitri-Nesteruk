using System;

namespace DesignPatternSample.Structural.Bridge
{
    class VectorRenderer : IRenderer
    {
        public void DrawCircle(float factor)
        {
            Console.WriteLine($"Draw a circle using vector with radius {factor}");
        }
    }
}
