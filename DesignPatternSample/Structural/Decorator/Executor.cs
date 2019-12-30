using DesignPatternSample.Structural.Decorator.DynamicComposition;
using DesignPatternSample.Structural.Decorator.MultipleInheritance;

namespace DesignPatternSample.Structural.Decorator
{
    class Executor
    {
        public Executor()
        {
            // Custom StringBuilder Demo
            //new CustomStringBuilderDemo();

            // Multiple Inheritance Demo
            //new MultipleInheritanceDemo();

            // DynamicComposition Demo
            new DynamicCompositionDemo();
        }
    }
}
