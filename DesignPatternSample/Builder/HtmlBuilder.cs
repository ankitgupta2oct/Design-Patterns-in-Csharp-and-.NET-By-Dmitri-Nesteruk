namespace DesignPatternSample.Builder
{
    class HtmlBuilder
    {
        public HtmlElement _root;
        public HtmlBuilder(string name)
        {
            _root = new HtmlElement
            {
                Name = name
            };
        }

        public HtmlBuilder AddChild(string name, string value)
        {
            _root.Childs.Add(new HtmlElement(name, value));
            return this;
        }

        public void Clear()
        {
            var rootName = _root.Name;
            _root = new HtmlElement
            {
                Name = rootName
            };
        }

        public override string ToString()
        {
            return _root.ToString();
        }
    }
}
