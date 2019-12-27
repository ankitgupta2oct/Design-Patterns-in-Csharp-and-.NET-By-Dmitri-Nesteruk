using System;

namespace DesignPatternSample.Structural.Bridge
{
    class RasterRenderer : IRenderer
    {
        public void DrawCircle(float factor)
        {
            Console.WriteLine($"Draw a circle using raster with radius {factor}");
        }
    }
}
