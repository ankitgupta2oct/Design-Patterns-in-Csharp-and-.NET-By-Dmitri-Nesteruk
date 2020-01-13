namespace DesignPatternSample.Behavioral.Command.BankAccount
{
    interface ICommand
    {
        void Invoke();
        void Undo();
    }
}