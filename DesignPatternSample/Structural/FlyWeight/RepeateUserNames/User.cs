namespace DesignPatternSample.Structural.FlyWeight.RepeateUserNames
{
    class User
    {
        private string _firstName;
        private string _lastName;

        public User(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public override string ToString()
        {
            return $"{_firstName} {_lastName}";
        }
    }
}