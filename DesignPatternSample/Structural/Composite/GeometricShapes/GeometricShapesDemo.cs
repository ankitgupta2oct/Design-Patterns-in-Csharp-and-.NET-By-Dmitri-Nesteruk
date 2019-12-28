using System;

namespace DesignPatternSample.Structural.Composite.GeometricShapes
{
    internal class GeometricShapesDemo
    {
        public GeometricShapesDemo()
        {
            var geometricObject = new GeometricObject();
            geometricObject.Childerns.Add(new Circle { Color = "Red" });
            geometricObject.Childerns.Add(new Square { Color = "Green" });

            var myShapes = new GeometricObject { Name = "My Shapes" };
            myShapes.Childerns.Add(new Circle { Color = "Blue" });
            myShapes.Childerns.Add(new Square { Color = "Yellow" });

            geometricObject.Childerns.Add(myShapes);

            Console.WriteLine(geometricObject);
        }
    }
}