using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class Queue
    {
        Node Head = null;
        Node Tail = null;
        internal void Append(int Data)
        {
            Node node = new Node(Data);
            if (Head == null)
            {
                Head = node;
                Tail = Head;
                Console.WriteLine("added " + Head.data);
            }
            else
            {
                Tail.Next = node;
                Tail = node;
                Console.WriteLine("added " + Tail.data);

            }
        }
        internal void Display()
        {
            Node temp = Head;
            if (Head == null)
            {
                Console.WriteLine();
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Queue elements are");
                while (temp != null)
                {
                    Console.Write("{0} ", temp.data);
                    temp = temp.Next;

                }
            }
            Console.WriteLine();
        }
        internal void Dequeue()
        {
            if (Head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine();
                while (Head != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("{0} deleted ", Head.data);
                    Head = Head.Next;
                    Display();
                }
            }
           
        }
    }
}
