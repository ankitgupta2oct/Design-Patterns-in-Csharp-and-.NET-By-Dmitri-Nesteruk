namespace DesignPatternSample.Behavioral.Command.BankAccount
{
    class BankAccountCommand : ICommand
    {
        public bool IsSuccedded;

        private Account _bankAccount;
        private Action _action;
        private int _amount;

        public BankAccountCommand(Account bankAccount, Action action, int amount)
        {
            _bankAccount = bankAccount;
            _action = action;
            _amount = amount;
        }

        public void Invoke()
        {
            switch (_action)
            {
                case Action.Deposite:
                    _bankAccount.Deposit(_amount);
                    IsSuccedded = true;
                    break;
                case Action.Withdraw:
                    IsSuccedded = _bankAccount.Withdraw(_amount);
                    break;
            }
        }

        public void Undo()
        {
            if (!IsSuccedded)
                return;

            switch (_action)
            {
                case Action.Deposite:
                    _bankAccount.Withdraw(_amount);
                    break;
                case Action.Withdraw:
                    _bankAccount.Deposit(_amount);
                    break;
            }
        }
    }
}