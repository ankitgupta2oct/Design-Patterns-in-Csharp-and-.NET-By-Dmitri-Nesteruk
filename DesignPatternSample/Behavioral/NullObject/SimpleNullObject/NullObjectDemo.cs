namespace DesignPatternSample.Behavioral.NullObject.SimpleNullObject
{
    internal class NullObjectDemo
    {
        public NullObjectDemo()
        {
            var log = new NullLog();
            var account = new BankAccount(log, 100);
            account.Withdraw(200);
            account.Withdraw(50);
        }
    }
}