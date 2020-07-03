namespace DesignPatternSample.Behavioral.TemplateMethod
{
    class Executor
    {
        public Executor()
        {
            Game game = new Ludo();
            game.Play();
        }
    }
}
