using System;

namespace DesignPatternSample.Creational.Singleton
{
    class Executor
    {
        public Executor()
        {
            var dataBase = SingletonDatabase.Insance;
            Console.WriteLine(dataBase.GetCityCount("bangalore"));
        }
    }
}
