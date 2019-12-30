namespace DesignPatternSample.Structural.Facade
{
    internal class SubSystemOne
    {
        public void ProcessSubSystem()
        {
            System.Console.WriteLine($"Processing {GetType().Name}");
        }
    }
}