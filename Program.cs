using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedList<int> linkedList = new LinkedList<int>();


            linkedList.AddFirst(30);
            linkedList.AddLast(98);
            linkedList.AddLast(20);
            //linkedList.RemoveFirst();
            //linkedList.Clear();

            //linkedList.Remove(30);
            //linkedList.RemoveLast();

            
            bool result = linkedList.Contains(20);
            ;
        }
    } 
}
