using System.Collections.Generic;

namespace DesignPatternSample.Behavioral.Iterator
{
    class BinaryTree<T>
    {
        private readonly Node<T> Current;

        public BinaryTree(Node<T> current)
        {
            Current = current;
        }

        public IEnumerable<Node<T>> InOrderEnumerable
        {
            get
            {
                foreach (var item in Transaction(Current))
                {
                    yield return item;
                }

                IEnumerable<Node<T>> Transaction(Node<T> value)
                {
                    if (value.Left != null)
                    {
                        foreach (var item in Transaction(value.Left))
                        {
                            yield return item;
                        }
                    }

                    yield return value;

                    if (value.Right != null)
                    {
                        foreach (var item in Transaction(value.Right))
                        {
                            yield return item;
                        }
                    }
                }
            }
        }
    }
}