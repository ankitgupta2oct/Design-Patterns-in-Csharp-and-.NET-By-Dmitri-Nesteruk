namespace DesignPatternSample.Behavioral.ChainOfResponsibility.MethodChain
{
    class DoubleAttackModifier : CreatureModifier
    {
        public DoubleAttackModifier(Creature creature) : base(creature) {}

        public override void Handle()
        {
            Creature.Attack *= 2;
            base.Handle();
        }
    }
}
