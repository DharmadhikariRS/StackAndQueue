namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to stack and queue");

            Console.WriteLine("Enter 1 to push elements into stack");
            Console.WriteLine("Enter 2 to Peek and Pop elements From stack");
            Console.WriteLine("Enter 3 to append elements in queue");
            int Num=int.Parse(Console.ReadLine());
            Stack stack = new Stack();
            Queue queue = new Queue();
            switch (Num)
            {
                case 1:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    break;
                    case 2:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    stack.Pop();
                    break;
                    case 3:
                    queue.Append(56);
                    queue.Append(30);
                    queue.Append(70);
                    queue.Display();
                    break;
                default:
                    Console.WriteLine("Enter correct input");
                    break;
            }



        }
    }
}