namespace DesignPatternSample.Behavioral.Memento
{
    internal class UndoRedoDemo
    {
        public UndoRedoDemo()
        {
            var account = new BankAccount(100);
            account.Deposite(50);
            account.Deposite(25);
            System.Console.WriteLine(account);

            account.Undo();
            System.Console.WriteLine(account);
            account.Redo();
            System.Console.WriteLine(account);
        }
    }
}