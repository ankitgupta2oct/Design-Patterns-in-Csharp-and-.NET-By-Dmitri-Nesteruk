using JetBrains.dotMemoryUnit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternSample.Structural.FlyWeight.RepeateUserNames
{

    [TestFixture]
    internal class RepeateUserNamesDemo
    {
        private Random _random;

        [SetUp]
        public void Setup()
        {
            _random = new Random();
        }

        [Test]
        private void CheckMemoryForUserOne()
        {
            string[] firstNameList = Enumerable.Range(0, 100).Select(_ => GetRandomString()).ToArray();
            string[] lastNameList = Enumerable.Range(0, 100).Select(_ => GetRandomString()).ToArray();

            var userList = new List<User>();
            foreach (var firstName in firstNameList)
                foreach (var lastName in lastNameList)
                    userList.Add(new User(firstName, lastName));

            ForceGC();

            dotMemory.Check((memory) => Console.WriteLine(memory.SizeInBytes));
        }
        
        [Test]
        private void CheckMemoryForUserTwo()
        {
            string[] firstNameList = Enumerable.Range(0, 100).Select(_ => GetRandomString()).ToArray();
            string[] lastNameList = Enumerable.Range(0, 100).Select(_ => GetRandomString()).ToArray();

            var userList = new List<UserTwo>();
            foreach (var firstName in firstNameList)
                foreach (var lastName in lastNameList)
                    userList.Add(new UserTwo(firstName, lastName));

            ForceGC();

            dotMemory.Check((memory) => Console.WriteLine(memory.SizeInBytes));
        }

        private void ForceGC()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private string GetRandomString()
        {
           return new string(Enumerable.Range(0, 10).Select(i => (char)('a' + _random.Next(26))).ToArray());
        }
    }
}