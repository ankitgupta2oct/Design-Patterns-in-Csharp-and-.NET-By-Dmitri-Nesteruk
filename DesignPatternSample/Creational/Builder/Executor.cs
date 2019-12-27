using DesignPatternSample.Creational.Builder.FacetedBuilder;
using System;

namespace DesignPatternSample.Creational.Builder
{
    class Executor
    {
        public Executor()
        {
            // Example 1
            var htmlBuilder = new HtmlBuilder("ul");
            htmlBuilder.AddChild("li", "Hello")
                       .AddChild("li", "World");
            Console.WriteLine(htmlBuilder.ToString());

            // Example 2
            var person = new PersonBuilder()
                .Lives
                    .In("Bangalore")
                    .At("xyz")
                    .WithPostcode("1234")
                .Works
                    .AsA("Developer")
                    .At("Xyz")
                    .Earning(000000);

            Console.WriteLine(person);
        }
    }
}