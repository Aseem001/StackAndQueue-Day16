// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Aseem Anand"/>
// --------------------------------------------------------------------------------------------------------------------
namespace StacksAndQueueUsingLinkedList
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            /// UC 4
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
            queue.Dequeue();
            queue.Display();
            queue.Dequeue();
            queue.Display();
            Console.ReadKey();
        }
    }
}
