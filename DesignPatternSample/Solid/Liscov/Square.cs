namespace DesignPatternSample.Solid.Liscov
{
    class Square : Rectangle
    {
        internal override int Height
        {
            set 
            {
                base.Height = base.Width = value;
            }
        }

        internal override int Width
        {
            set
            {
                base.Height = base.Width = value;
            }
        }
    }
}
