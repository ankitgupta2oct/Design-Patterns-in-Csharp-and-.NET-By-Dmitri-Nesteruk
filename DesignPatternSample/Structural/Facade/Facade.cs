namespace DesignPatternSample.Structural.Facade
{
    class Facade
    {
        private readonly SubSystemOne _subSystemOne;
        private readonly SubSystemTwo _subSystemTwo;
        private readonly SubSystemThree _subSystemThree;
        private readonly SubSystemFour _subSystemfour;

        public Facade()
        {
            _subSystemOne = new SubSystemOne();
            _subSystemTwo = new SubSystemTwo();
            _subSystemThree = new SubSystemThree();
            _subSystemfour = new SubSystemFour();
        }

        public void ProcessSystem()
        {
            _subSystemOne.ProcessSubSystem();
            _subSystemTwo.ProcessSubSystem();
            _subSystemThree.ProcessSubSystem();
            _subSystemfour.ProcessSubSystem();
        }
    }
}