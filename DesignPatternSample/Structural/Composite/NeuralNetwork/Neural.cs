using System.Collections;
using System.Collections.Generic;

namespace DesignPatternSample.Structural.Composite.NeuralNetwork
{
    internal class Neural : IEnumerable<Neural>
    {
        public List<Neural> In, Out;

        public IEnumerator<Neural> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
