namespace DesignPatternSample.Behavioral.ChainOfResponsibility.MethodChain
{
    class CreatureModifier
    {
        protected Creature Creature;

        public CreatureModifier(Creature creature)
        {
            Creature = creature;
        }

        private CreatureModifier _next;

        public virtual void Handle() => _next?.Handle();

        public void Add(CreatureModifier creatureModifier)
        {
            if (_next == null)
                _next = creatureModifier;
            else
                _next.Add(creatureModifier);
        }
    }
}
