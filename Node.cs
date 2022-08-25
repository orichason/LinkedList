using System;
namespace LinkedList
{
    public class Node<T>
    {
        public T Value;
        public Node<T> Next;

        public Node(T value)
        {
            Value = value;
        }

        public Node(T value, Node<T> next)
        {
            Value = value;
            Next = next;
        }
    }
}
