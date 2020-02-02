namespace DesignPatternSample.Behavioral.NullObject
{
    class BankAccount
    {
        private readonly ILog _log;
        public int Balance { get; private set; }

        public BankAccount(ILog log, int amout)
        {
            _log = log;
            Balance += amout;
        }

        public void Withdraw(int amout)
        {
            if(Balance >= amout)
            {
                Balance -= amout;
                _log.Debug($"Withdraw {amout}, now Balance is {Balance}");
            }
            else
            {
                _log.Warning("WARNING: Insufficient Fund!!!");
            }
        }
    }
}
