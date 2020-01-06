namespace DesignPatternSample.Behavioral.ChainOfResponsibility.MethodChain
{
    class NoBonusModifier : CreatureModifier
    {
        public NoBonusModifier(Creature creature) : base(creature) { }

        public override void Handle()
        {
             // Breaking Chain
        }
    }
}
