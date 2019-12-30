namespace DesignPatternSample.Structural.Facade
{
    internal class SubSystemFour
    {
        public void ProcessSubSystem()
        {
            System.Console.WriteLine($"Processing {GetType().Name}");
        }
    }
}