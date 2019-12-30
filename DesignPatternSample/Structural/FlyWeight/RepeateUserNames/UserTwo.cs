using System.Collections.Generic;

namespace DesignPatternSample.Structural.FlyWeight.RepeateUserNames
{
    class UserTwo
    {
        private string _firstName;
        private string _lastName;

        static List<string> firstNameList = new List<string>();
        static List<string> lastNameList = new List<string>();

        public UserTwo(string firstName, string lastName)
        {
            _firstName = GetOrUpdate(firstNameList, firstName);
            _lastName = GetOrUpdate(lastNameList, lastName);
        }

        private string GetOrUpdate(List<string> list, string value)
        {
            if (list.IndexOf(value) != -1)
                return list[list.IndexOf(value)];

            list.Add(value);
            return value;
        }

        public override string ToString()
        {
            return $"{_firstName} {_lastName}";
        }
    }
}