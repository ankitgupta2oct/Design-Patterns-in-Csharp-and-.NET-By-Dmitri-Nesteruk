using System;
using System.Linq;

namespace DesignPatternSample.Behavioral.Iterator
{
    internal class IteratorMethodDemo
    {
        public IteratorMethodDemo()
        {
            var root = new Node<int>(1, new Node<int>(2), new Node<int>(3));
            var tree = new BinaryTree<int>(root);
            Console.WriteLine(string.Join(',', tree.InOrderEnumerable.Select(x => x.Value)));
        }
    }
}