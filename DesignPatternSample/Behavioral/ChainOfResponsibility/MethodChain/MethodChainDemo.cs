using System;

namespace DesignPatternSample.Behavioral.ChainOfResponsibility.MethodChain
{
    class MethodChainDemo
    {
        public MethodChainDemo()
        {
            var creature = new Creature { Name = "Godzilla", Attack = 2, Defence = 2 };

            Console.WriteLine(creature);

            var root = new CreatureModifier(creature);


            root.Add(new NoBonusModifier(creature));
            root.Add(new DoubleAttackModifier(creature));
            root.Add(new IncreaseDefeneceModifier(creature));

            root.Handle();

            Console.WriteLine(creature);
        }
    }
}
