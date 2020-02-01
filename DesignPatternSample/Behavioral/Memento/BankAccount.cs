using System.Collections.Generic;

namespace DesignPatternSample.Behavioral.Memento
{
    class BankAccount
    {
        private readonly IList<Memento> tansactionMementos = new List<Memento>();
        private int currentMementoIndex = -1;

        public int Balance { get; private set; }

        public BankAccount(int amount)
        {
            Deposite(amount);
        }

        public Memento Deposite(int amount)
        {
            Balance += amount;
            var memento = new Memento(Balance);
            tansactionMementos.Add(memento);
            currentMementoIndex++;
            return memento;
        }

        public bool Undo()
        {
            if(currentMementoIndex > 0)
            {
                var memento = tansactionMementos[--currentMementoIndex];
                Balance = memento.Balance;
                return true;
            }
            return false;
        }

        public bool Redo()
        {
            if ((currentMementoIndex + 1) < tansactionMementos.Count)
            {
                var memento = tansactionMementos[++currentMementoIndex];
                Balance = memento.Balance;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{nameof(Balance)} : {Balance}";
        }
    }
}