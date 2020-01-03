namespace DesignPatternSample.Structural.Proxy.DynamicLoggingProxy
{
    public interface IBankAccount
    {
        void Deposit(int amount);
        bool Withdraw(int amount);
        string ToString();
    }
}
