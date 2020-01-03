using System;

namespace DesignPatternSample.Structural.Proxy.PropertyProxy
{
    class PropertyProxyDemo
    {
        public PropertyProxyDemo()
        {
            var creature = new Creature();
            creature.Age.Value = 25;
            Console.WriteLine(creature.Age);
        }
    }
}
