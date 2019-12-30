using System.Text;

namespace DesignPatternSample.Structural.FlyWeight.TextFormatting
{
    class FormattedText
    {
        private readonly string _plainText;
        private readonly bool[] _capitalizeArray;

        public FormattedText(string formattedText)
        {
            _plainText = formattedText;
            _capitalizeArray = new bool[formattedText.Length];
        }

        public void Capitalize(int start, int length)
        {
            for (int i = start; i <= (start + length); i++)
            {
                _capitalizeArray[i] = true;
            }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            for (int index = 0; index < _plainText.Length; index++)
            {
                var @char = _plainText[index];
                stringBuilder.Append(_capitalizeArray[index] ? char.ToUpper(@char) : @char);
            }

            return stringBuilder.ToString();
        }
    }
}
