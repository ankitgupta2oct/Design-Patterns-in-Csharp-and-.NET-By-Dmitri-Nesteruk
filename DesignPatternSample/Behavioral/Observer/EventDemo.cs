using System;

namespace DesignPatternSample.Behavioral.Observer
{
    class FallIllEventHandler
    {
        public string Address { get; set; }
    }

    class Person
	{
        public event EventHandler<FallIllEventHandler> FallIll;

        public void CatchACold()
        {
            FallIll?.Invoke(this, new FallIllEventHandler { Address = "Bangalore" });
        }
    }


    internal class EventDemo
    {
        public EventDemo()
        {
            var person = new Person();
            person.FallIll += OnFallIllCalled;
            person.CatchACold();
        }

        private void OnFallIllCalled(object sender, FallIllEventHandler e)
        {
            Console.WriteLine($"Inform the doctor! and send medicine to {e.Address}");
        }
    }
}