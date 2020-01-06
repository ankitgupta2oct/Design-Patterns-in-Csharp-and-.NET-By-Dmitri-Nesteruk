namespace DesignPatternSample.Behavioral.ChainOfResponsibility.MethodChain
{
    class Creature
    {
        public string Name { set; get; }
        public int Defence { set; get; }
        public int Attack { set; get; }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Defence)}: {Defence}, {nameof(Attack)}: {Attack}";
        }
    }
}
