using System;
namespace LinkedList
{
    public class LinkedList<T>
    {
        public Node<T> Head;
        public Node<T> Tail;

        public int count { get; private set; }


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
            Node<T> cursor = Head.Next;

            while (cursor != null)
            {
                if (cursor == node)
                {
                    Node<T> NewNode = new Node<T>(value);
                    NewNode.Next = node;
                    cursor.Next = NewNode;
                }
            }
        }

        public void AddAfter(Node<T> node, T value)
        {
            Node<T> cursor = Head.Next;

            while(cursor != null)
            {
                if(cursor == node)
                {
                    Node<T> NewNode = new Node<T>(value);
                    NewNode.Next = node.Next;
                    cursor.Next = NewNode.Next;
                }
            }
        }

        public bool RemoveFirst()
        {
            if(Head == null)
            {
                return false;
            }

            else
            {
                if(Head == Tail)
                {
                    Tail = null;
                }
                Head = Head.Next;
                count--;
            }

            return true;

        }

        public bool RemoveLast()
        {
            Node<T> cursor = Head.Next;

            if(Head == null)
            {
                return false;
            }

            while (cursor.Next != null)
            {
                if (cursor.Next.Next == null)
                {
                    Tail = cursor;
                    cursor.Next = null;
                    count--;
                }
            }
            return true;
        }
    }
}
