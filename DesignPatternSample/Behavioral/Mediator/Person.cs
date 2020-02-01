namespace DesignPatternSample.Behavioral.Mediator
{
    internal class Person
    {
        public string Name { get; private set; }

        private ICharRoom _room;

        public Person(ICharRoom room, string name)
        {
            _room = room;
            Name = name;
        }

        public void SendMessage(string who, string message)
        {
            _room.SendMessage(Name, who, message);
        }

        public void ReceivedMessage(string source, string message)
        {
            System.Console.WriteLine($"[{Name} Console]:\n\t{source} sends: {message}");
        }
    }
}