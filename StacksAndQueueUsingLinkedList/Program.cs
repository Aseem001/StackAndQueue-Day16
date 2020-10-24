using System;

namespace StacksAndQueueUsingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {           
            Stack stack = new Stack();
            stack.PushToTop(70);
            stack.PushToTop(30);
            stack.PushToTop(56);
            stack.Display();
            stack.IsEmpty();
            stack.Display();
            Console.ReadKey();
        }
    }
}
