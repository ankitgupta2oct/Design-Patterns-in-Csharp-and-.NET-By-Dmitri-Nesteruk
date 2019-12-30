using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.Structural.FlyWeight.TextFormatting
{
    partial class BetterFormattedText
    {
        private readonly string _plainText;
        private readonly List<TextRange> _rangeList;

        public BetterFormattedText(string formattedText)
        {
            _plainText = formattedText;
            _rangeList = new List<TextRange>();
        }

        public TextRange GetRange(int start, int length)
        {
            var range = new TextRange(start, start + length);
            _rangeList.Add(range);
            return range;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            for (int index = 0; index < _plainText.Length; index++)
            {
                var @char = _plainText[index];
                foreach (var range in _rangeList)
                    if (range.IsInScope(index) && range.Capitalize)
                        @char = char.ToUpper(@char);

                stringBuilder.Append(@char);
            }

            return stringBuilder.ToString();
        }
    }
}
