namespace DesignPatternSample.Structural.Proxy.ProtectionProxy
{
    class Driver
    {
        public Driver(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public int Age { private set; get; }
        public string Name { private set; get; }
    }
}