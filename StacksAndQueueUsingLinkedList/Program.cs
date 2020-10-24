using System;

namespace StacksAndQueueUsingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            /// UC 3
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
            Console.ReadKey();
        }
    }
}
