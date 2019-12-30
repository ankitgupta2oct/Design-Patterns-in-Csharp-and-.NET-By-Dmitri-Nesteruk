namespace DesignPatternSample.Structural.Facade
{
    internal class SubSystemThree
    {
        public void ProcessSubSystem()
        {
            System.Console.WriteLine($"Processing {GetType().Name}");
        }
    }
}