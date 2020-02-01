using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSample.Behavioral.Mediator
{
    class CharRoom : ICharRoom
    {
        private readonly IList<Person> paricipient = new List<Person>();

        public void SendMessage(string source, string who, string message)
        {
            paricipient.FirstOrDefault((person) => person.Name == who)?.ReceivedMessage(source, message);
        }

        public bool Join(Person person)
        {
            if (!paricipient.Contains(person))
            {
                Parallel.ForEach(paricipient, (receiverPerson) =>
                {
                    receiverPerson.ReceivedMessage("Chat Room", $"{person.Name} joins the chat!");
                });
                paricipient.Add(person);
                return true;
            }
            return false;
        }

        public bool Leave(Person person)
        {
            if (paricipient.Contains(person))
            {
                paricipient.Remove(person);
                Parallel.ForEach(paricipient, (receiverPerson) =>
                {
                    receiverPerson.ReceivedMessage("Chat Room", $"{person.Name} leaves the chat!");
                });
                return true;
            }
            return false;
        }
    }
}