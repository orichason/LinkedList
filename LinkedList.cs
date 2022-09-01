using System;
namespace LinkedList
{
    public class LinkedList<T>
    {
        public Node<T> Head;
        public Node<T> Tail;

        public int Count { get; private set; }


        public void AddFirst(T value)
        {
            if (Head == null)
            {
                Head = Tail = new Node<T>(value);
                Count++;
            }

            else
            {
                Node<T> nodeToInsert = new Node<T>(value);
                nodeToInsert.Next = Head;
                Head = nodeToInsert;
                Count++;
            }

        }
        public void AddLast(T value)
        {
            if (Head == null)
            {
                Head = Tail = new Node<T>(value);
                Count++;
            }

            else
            {
                Node<T> node = new Node<T>(value);
                Tail.Next = node;
                Tail = node;
                Count++;
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
                    Count++;
                }
            }
        }

        public void AddAfter(Node<T> node, T value)
        {
            Node<T> cursor = Head.Next;

            while (cursor != null)
            {
                if (cursor == node)
                {
                    Node<T> NewNode = new Node<T>(value);
                    NewNode.Next = node.Next;
                    cursor.Next = NewNode;
                    Count++;
                }
            }
        }

        public bool RemoveFirst()
        {
            if (Head == null)
            {
                return false;
            }

            else
            {
                if (Head == Tail)
                {
                    Tail = null;
                }
                Head = Head.Next;
                Count--;
            }

            return true;

        }

        public bool RemoveLast()
        {
            Node<T> cursor = Head;

            if (Head == null)
            {
                return false;
            }

            while (cursor.Next != null)
            {
                if (cursor.Next.Next == null)
                {
                    Tail = cursor;
                    cursor.Next = null;
                    Count--;
                }
            }
            return true;
        }

        public bool Remove(T value)
        {

            if (Head.Value.Equals(value))
            {
                if (Head == Tail)
                {
                    Clear();
                }
                else
                {
                    Head = Head.Next;
                }
                return true;
            }

            Node<T> cursor = Head;

            while (cursor.Next != null)
            {
                if (cursor.Next.Value.Equals(value))
                {
                    if(cursor.Next == Tail)
                    {
                        Tail = cursor;
                    }
                    cursor.Next = cursor.Next.Next;
                    Count--;
                    return true;

                }

                cursor = cursor.Next;
            }

            return false;
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public Node<T> Search(T value)
        {
            Node<T> cursor = Head;

            while(cursor != null)
            {
                if(cursor.Value.Equals(value))
                {
                    return cursor;
                }

                cursor = cursor.Next;
            }

            return null;
        }

        public bool Contains (T value)
        {
            return Search(value) != null;
        }
    }
}
