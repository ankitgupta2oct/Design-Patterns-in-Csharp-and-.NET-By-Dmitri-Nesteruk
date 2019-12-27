using System;

namespace DesignPatternSample.Solid.OpenAndClose.Specification
{
    class Executor
    {
        public Executor()
        {
            var productList = new[]
            {
                new Product("Car", Color.Red, Size.Large),
                new Product("Auto", Color.Blue, Size.Large),
                new Product("Bus", Color.Red, Size.Huge)
            };

            var filter = new Filter();
            var filteredList = filter.GetFilteredData(productList, new ColorAndSizeSpecification(Size.Large, Color.Red));

            foreach (var item in filteredList)
                Console.WriteLine(item);
        }
    }
}
