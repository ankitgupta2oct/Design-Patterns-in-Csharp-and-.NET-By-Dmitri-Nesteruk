namespace DesignPatternSample.Structural.FlyWeight.TextFormatting
{
    class TextFormattingDemo
    {
        public TextFormattingDemo()
        {
            var formattedText = new FormattedText("I am Ankit Gupta");
            formattedText.Capitalize(5, 5);
            System.Console.WriteLine(formattedText);
            
            var betterformattedText = new BetterFormattedText("I am Ankit Gupta");
            betterformattedText.GetRange(5, 5).Capitalize = true;
            System.Console.WriteLine(betterformattedText);
        }
    }
}
