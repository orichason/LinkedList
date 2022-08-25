using System;
namespace LinkedList
{
    public class LinkedList<T>
    {
        public Node<T> Head;
        public Node<T> Tail;

        public int count { get; private set;}


        public void AddFirst(T value)
        {
            if (Head == null)
            {
                Head = Tail = new Node<T>(value);
                count++;
            }

            else
            {
                Node<T> nodeToInsert = new Node<T>(value);
                nodeToInsert.Next = Head;
                Head = nodeToInsert;
                count++;
            }    

        }
        public void AddLast(T value)
        {
            if (Head == null)
            {
                Head = Tail = new Node<T>(value);
                count++;
            }

            else
            {
                Node<T> node = new Node<T>(value);
                Tail.Next = node;
                Tail = node;
                count++;
            }
        }

        public void AddBefore(Node<T> node, T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (.Next == node)
                {
                    Node<T> NewNode = new Node<T>(value);
                    NewNode.Next = node;
                }
            }
        }
    }
}
