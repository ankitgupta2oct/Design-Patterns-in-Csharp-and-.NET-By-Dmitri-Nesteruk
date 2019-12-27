
namespace DesignPatternSample.Creational.Factory
{
    class Executor
    {
        public Executor()
        {
            var person = Person.Factory.NewPolarPoint(2, 3);
            System.Console.WriteLine(person);
        }
    }
}