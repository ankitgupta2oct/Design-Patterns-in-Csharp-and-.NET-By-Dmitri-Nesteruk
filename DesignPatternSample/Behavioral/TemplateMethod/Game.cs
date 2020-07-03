namespace DesignPatternSample.Behavioral.TemplateMethod
{
    abstract class Game
    {
        public void Play()
        {
            Start();
        }

        protected abstract void Start();
    }
}
