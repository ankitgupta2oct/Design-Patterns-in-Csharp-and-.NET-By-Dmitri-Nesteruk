namespace DesignPatternSample.Behavioral.Mediator
{
    internal class ChatRoomDemo
    {
        public ChatRoomDemo()
        {
            var chatRoom = new CharRoom();

            var jhon = new Person(chatRoom, "jhon");
            var jane = new Person(chatRoom, "jane");
            var simon = new Person(chatRoom, "simon");

            chatRoom.Join(jhon);
            chatRoom.Join(jane);

            jhon.SendMessage(jane.Name, "Hey Jane, welcome!");
            jane.SendMessage(jhon.Name, "Thank you");

            chatRoom.Join(simon);

            chatRoom.Leave(jhon);
        }
    }
}