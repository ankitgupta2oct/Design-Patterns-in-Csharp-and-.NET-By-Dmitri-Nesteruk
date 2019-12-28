using System.Collections.Generic;

namespace DesignPatternSample.Structural.Composite.NeuralNetwork
{
    static class EnumerableExtention
    {
        public static void ConnectTo(this IEnumerable<Neural> self, IEnumerable<Neural> others)
        {
            if (ReferenceEquals(self, others)) return;

            foreach (var other in others)
            foreach (var inObject in self)
            {
                inObject.Out.Add(other);
                other.In.Add(inObject);
            }
        }
    }
}
