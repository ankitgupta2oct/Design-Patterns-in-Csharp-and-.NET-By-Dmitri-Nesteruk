namespace DesignPatternSample.Behavioral.NullObject
{
    class ConsoleLog : ILog
    {
        public void Debug(string message)
        {
            System.Console.WriteLine(message);
        }

        public void Warning(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}
