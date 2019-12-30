namespace DesignPatternSample.Structural.FlyWeight.TextFormatting
{
    partial class BetterFormattedText
    {
        internal class TextRange
        {
            public bool Capitalize, Bold, Italic;
            private int _start, _end;

            public TextRange(int start, int end)
            {
                _start = start;
                _end = end;
            }

            public bool IsInScope(int index)
            {
                return index >= _start && index <= _end;
            }
        }
    }
}
