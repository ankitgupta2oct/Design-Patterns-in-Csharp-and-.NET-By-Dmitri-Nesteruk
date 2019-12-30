namespace DesignPatternSample.Structural.Decorator.MultipleInheritance
{
    class Dragon : IBird, ILizard
    {
        private IBird _bird;
        private ILizard _lizard;
        private int _weight;

        public Dragon(IBird bird, ILizard lizard)
        {
            _bird = bird;
            _lizard = lizard;
        }

        public int Weight
        {
            get => _weight;
            set
            {
                _weight = _lizard.Weight = _bird.Weight = value;
            }
        }

        public void Crawl()
        {
            _lizard.Crawl();
        }

        public void Fly()
        {
            _bird.Fly();
        }
    }
}
