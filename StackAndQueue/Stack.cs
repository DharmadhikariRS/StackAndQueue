using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class Stack
    {
        Node Top = null;
        internal void Push(int Data)
        {
            Node node = new Node(Data);

            if (Top == null)
            {
                Top = node;

                Console.WriteLine("added " + Top.data);
            }
            else
            {
                Node temp = node;
                temp.Next = Top;
                Top = temp;
                Console.WriteLine("added " + Top.data);
            }

        }
        internal void Display()
        {
            Node temp = Top;
            if (Top == null)
            {
                Console.WriteLine("stack is Empty");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Stack elements are");
                while (temp != null)
                {
                    Console.WriteLine("{0} ", temp.data);
                    temp = temp.Next;

                }
            }
            Console.WriteLine();
        }
        public void Peek()
        {
            if (Top == null)
            {
                Console.WriteLine("No element present");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("peek element of stack= " + Top.data);
            }
        }
        internal void Pop()
        {
            if (Top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine();
                while (Top != null)
                {
                    Peek();
                    int PeekValue = Top.data;

                    Top = Top.Next;

                    Console.WriteLine("Deleted element= " + PeekValue);
                    Display();


                }
            }
            Console.WriteLine();
        }
    }
}
