namespace DesignPatternSample.Structural.Bridge
{
    class BridgeDemo
    {
        public BridgeDemo()
        {
            var renderer = new VectorRenderer();
            //var renderer = new RasterRenderer();

            var shape = new Circle(renderer, 2.0f);

            shape.Draw();
            shape.Resize(4.0f);
            shape.Draw();
        }
    }
}
