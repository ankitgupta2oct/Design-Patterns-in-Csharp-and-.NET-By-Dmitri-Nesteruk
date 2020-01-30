namespace DesignPatternSample.Behavioral.Iterator
{
    class Node<T>
    {
        //public Node<T> Parent;
        public Node<T> Left, Right;
        public T Value;

        public Node(T value)
        {
            Value = value;
        }

        public Node(T value, Node<T> left, Node<T> right)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }
}