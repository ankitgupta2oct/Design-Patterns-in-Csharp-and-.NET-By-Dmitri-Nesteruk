using System;

namespace DesignPatternSample.Prototype
{
    class Person
    {
        public Person(string[] names, Address address)
        {
            Names = names;
            Address = address;
        }

        public string[] Names { get; set; }
        public Address Address { get; set; }

        public override string ToString()
        {
            return $"Names: {string.Join(" ", Names)}, Address: {Address}";
        }
    }
}
