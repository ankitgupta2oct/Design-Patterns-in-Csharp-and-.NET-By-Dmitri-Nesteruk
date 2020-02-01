namespace DesignPatternSample.Behavioral.Mediator
{
    interface ICharRoom
    {
        bool Join(Person person);
        bool Leave(Person person);
        void SendMessage(string source, string who, string message);
    }
}