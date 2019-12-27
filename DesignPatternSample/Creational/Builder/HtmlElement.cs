using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.Creational.Builder
{
    class HtmlElement
    {
        internal string Name;
        internal string Value;
        internal List<HtmlElement> Childs = new List<HtmlElement>();

        private const int IndentSize = 2;

        public HtmlElement() { }

        public HtmlElement(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string ToString(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', IndentSize * indent);
            sb.Append($"{i}<{Name}>\n");
            if (!string.IsNullOrWhiteSpace(Value))
            {
                sb.Append(new string(' ', IndentSize * (indent + 1)));
                sb.Append(Value);
                sb.Append("\n");
            }

            foreach (var e in Childs)
                sb.Append(e.ToString(indent + 1));

            sb.Append($"{i}</{Name}>\n");
            return sb.ToString();
        }

        public override string ToString()
        {
            return ToString(0);
        }
    }
}
