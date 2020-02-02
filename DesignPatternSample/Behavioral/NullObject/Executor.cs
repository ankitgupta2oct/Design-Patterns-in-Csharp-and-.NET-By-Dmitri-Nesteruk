using DesignPatternSample.Behavioral.NullObject.DynamicNullObject;
using DesignPatternSample.Behavioral.NullObject.SimpleNullObject;

namespace DesignPatternSample.Behavioral.NullObject
{
    class Executor
    {
        public Executor()
        {
            new NullObjectDemo();

            new DynamicNullObjectDemo();
        }
    }
}
