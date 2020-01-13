using System.Collections.Generic;
using System.Linq;

namespace DesignPatternSample.Behavioral.Command.BankAccount
{
    internal class TransactionDemo
    {
        public TransactionDemo()
        {
            var account = new Account();
            System.Console.WriteLine(account);

            var commandList = new List<ICommand>()
            {
                new BankAccountCommand(account, Action.Deposite, 1000),
                new BankAccountCommand(account, Action.Withdraw, 500)
            };

            foreach (var command in commandList)
                command.Invoke();
            System.Console.WriteLine(account);

            System.Console.WriteLine("----------- Undo -----------");

            foreach (var command in Enumerable.Reverse(commandList))
                command.Undo();
            System.Console.WriteLine(account);
        }
    }
}