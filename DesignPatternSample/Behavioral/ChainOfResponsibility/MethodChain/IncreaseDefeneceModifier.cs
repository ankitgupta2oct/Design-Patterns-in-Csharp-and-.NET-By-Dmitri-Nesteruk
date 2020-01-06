namespace DesignPatternSample.Behavioral.ChainOfResponsibility.MethodChain
{
    class IncreaseDefeneceModifier : CreatureModifier
    {
        public IncreaseDefeneceModifier(Creature creature) : base(creature) {}

        public override void Handle()
        {
            Creature.Defence += 5;
            base.Handle();
        }
    }
}
