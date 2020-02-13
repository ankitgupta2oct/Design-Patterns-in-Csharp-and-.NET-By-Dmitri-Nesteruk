using System;
using System.Text;

namespace DesignPatternSample.Behavioral.State.SwitchBasedStateMachine
{
    internal class SwitchBasedStateMachineDemo
    {
        const string Code = "1234";
        readonly StringBuilder entry = new StringBuilder();

        public SwitchBasedStateMachineDemo()
        {
            StartMachine();
        }

        private void StartMachine()
        {
            var state = State.Locked;
            while (true)
            {
                switch (state)
                {
                    case State.Locked:
                        entry.Append(Console.ReadKey().KeyChar);
                        if (entry.ToString().Equals(Code))
                        {
                            state = State.Unlocked;
                        }
                        if(!Code.StartsWith(entry.ToString()))
                        {
                            state = State.Failed;
                        }
                        break;
                    case State.Failed:
                        Console.CursorLeft = 0;
                        Console.WriteLine("Failed");
                        state = State.Locked;
                        entry.Clear();
                        break;
                    case State.Unlocked:
                        Console.CursorLeft = 0;
                        Console.WriteLine("Unlocked");
                        state = State.Locked;
                        entry.Clear();
                        break;
                }
            }
        }
    }
}