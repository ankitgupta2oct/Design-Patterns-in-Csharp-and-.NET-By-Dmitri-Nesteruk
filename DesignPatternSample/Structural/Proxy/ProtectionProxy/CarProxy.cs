namespace DesignPatternSample.Structural.Proxy.ProtectionProxy
{
    class CarProxy : ICar
    {
        readonly ICar _car = new Car();

        public void Drive(Driver driver)
        {
            if (driver.Age >= 18)
                _car.Drive(driver);
            else
                System.Console.WriteLine("You're too young...");
        }
    }
}