using System;

namespace DesignPatternSample.Structural.Proxy.DynamicLoggingProxy
{
    class DynamicLoggingProxyDemo
    {
        public DynamicLoggingProxyDemo()
        {
            //var ba = new BankAccount();
            var ba = Log<BankAccount>.As<IBankAccount>();

            ba.Deposit(100);
            ba.Withdraw(50);

            Console.WriteLine(ba);
        }
    }
}
