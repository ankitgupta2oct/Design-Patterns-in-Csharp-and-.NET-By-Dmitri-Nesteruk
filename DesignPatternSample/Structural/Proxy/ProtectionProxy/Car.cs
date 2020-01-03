namespace DesignPatternSample.Structural.Proxy.ProtectionProxy
{
    class Car : ICar
    {
        public void Drive(Driver driver)
        {
            System.Console.WriteLine($"{driver.Name} is driving a car");
        }
    }
}