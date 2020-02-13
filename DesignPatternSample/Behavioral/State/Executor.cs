using DesignPatternSample.Behavioral.State.StateMachine;
using DesignPatternSample.Behavioral.State.SwitchBasedStateMachine;

namespace DesignPatternSample.Behavioral.State
{
    class Executor
    {
        public Executor()
        {
            // Simple State Machine
            //new StateMachineDemo();

            // Switch Based State Machine
            new SwitchBasedStateMachineDemo();
        }
    }
}
