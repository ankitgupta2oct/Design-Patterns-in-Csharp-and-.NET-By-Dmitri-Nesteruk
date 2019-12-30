namespace DesignPatternSample.Structural.Decorator.MultipleInheritance
{
    class MultipleInheritanceDemo
    {
        public MultipleInheritanceDemo()
        {
            var dragon = new Dragon(new Bird(), new Lizard());

            dragon.Weight = 200;
            dragon.Fly();
            dragon.Crawl();
        }
    }
}
