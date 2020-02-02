namespace DesignPatternSample.Behavioral.NullObject.SimpleNullObject
{
    class NullLog : ILog
    {
        public void Debug(string message)
        {
        }

        public void Warning(string message)
        {
        }
    }
}