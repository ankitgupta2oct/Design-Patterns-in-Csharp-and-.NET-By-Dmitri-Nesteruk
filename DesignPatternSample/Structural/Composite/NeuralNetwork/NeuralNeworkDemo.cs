namespace DesignPatternSample.Structural.Composite.NeuralNetwork
{
    class NeuralNeworkDemo
    {
        public NeuralNeworkDemo()
        {
            var neural1 = new Neural();
            var neural2 = new Neural();

            var neuralLayer1 = new NeuralLayer();
            var neuralLayer2 = new NeuralLayer();


            // Single object to single object
            neural1.ConnectTo(neural2);

            // Single object to composite objects
            neural1.ConnectTo(neuralLayer1);

            // composite objects to composite objects
            neuralLayer1.ConnectTo(neuralLayer2);
        }
    }
}
