using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.Structural.Composite.GeometricShapes
{
    internal class GeometricObject
    {
        public virtual string Name { set; get; } = "GeometricObject";
        public string Color { set; get; }

        private Lazy<List<GeometricObject>> _childerns = new Lazy<List<GeometricObject>>();
        public List<GeometricObject> Childerns => _childerns.Value;

        public void Print(StringBuilder stringBuilder, int depth)
        {
            stringBuilder
                .Append(new string('*', depth))
                .Append(Color ?? string.Empty)
                .AppendLine(Name);

            foreach (var child in Childerns)
            {
                child.Print(stringBuilder, depth + 1);
            }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            Print(stringBuilder, 0);
            return stringBuilder.ToString();
        }
    }
}