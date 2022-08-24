namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to stack and queue");

            Console.WriteLine("Enter 1 to push elements into stack");
            int Num=int.Parse(Console.ReadLine());
            Stack stack = new Stack();
            switch (Num)
            {
                case 1:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    break;
                default:
                    Console.WriteLine("Enter correct input");
                    break;
            }



        }
    }
}