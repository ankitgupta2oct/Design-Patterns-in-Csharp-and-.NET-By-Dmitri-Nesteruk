using System;

namespace DesignPatternSample.Structural.Decorator.CustomStringBuilder
{
    class CustomStringBuilderDemo
    {
        public CustomStringBuilderDemo()
        {
            CustomStringBuilder text = "Hello ";
            text += "World";

            Console.WriteLine(text);
        }
    }
}
