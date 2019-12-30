namespace DesignPatternSample.Structural.Facade
{
    internal class SubSystemTwo
    {
        public void ProcessSubSystem()
        {
            System.Console.WriteLine($"Processing {GetType().Name}");
        }
    }
}