namespace DesignPatternSample.Behavioral.NullObject.DynamicNullObject
{
    internal class DynamicNullObjectDemo
    {
        public DynamicNullObjectDemo()
        {
            var log = Null<ILog>.Instance;

            var account = new BankAccount(log, 100);
            account.Withdraw(200);
            account.Withdraw(50);
        }
    }
}