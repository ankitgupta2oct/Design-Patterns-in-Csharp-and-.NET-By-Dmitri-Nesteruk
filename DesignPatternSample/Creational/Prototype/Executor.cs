using System;

namespace DesignPatternSample.Creational.Prototype
{
    class Executor
    {
        public Executor()
        {
            var person1 = new Person(new[] { "Ankit", "Vishal" }, new Address("Bangalore", 12));
            var person2 = person1.DeepCopy();

            person2.Names[0] = "Rohit";
            person2.Address.HouseNumber = 44;

            Console.WriteLine(person1);
            Console.WriteLine(person2);
        }
    }
}
