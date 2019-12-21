using System;

namespace DesignPatternSample.Singleton
{
    class SingletonDatabase : IDataBase
    {
        private static Lazy<SingletonDatabase> _insance =>
            new Lazy<SingletonDatabase>(() => new SingletonDatabase());

        public static SingletonDatabase Insance => _insance.Value;

        private SingletonDatabase() {}

        public int GetCityCount(string city)
        {
            return 300;
        }
    }
}
