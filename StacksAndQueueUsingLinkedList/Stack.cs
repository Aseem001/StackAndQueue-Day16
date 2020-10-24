// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Stack.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Aseem Anand"/>
// --------------------------------------------------------------------------------------------------------------------

namespace StacksAndQueueUsingLinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class Stack
    {
        public Node top;

        /// <summary>
        /// UC 1 : Pushesthe value to top of the stack.
        /// </summary>
        /// <param name="value">The value.</param>
        public void PushToTop(int value)
        {
            Node newNode = new Node(value);
            if(this.top==null)
            {                
                newNode.next = null;
            }
            else
            {
                newNode.next = this.top;
            }
            this.top = newNode;
            Console.WriteLine("{0} pushed at top of stack",value);
        }

        /// <summary>
        /// Peeks the top element.
        /// </summary>
        public void PeekTopElement()
        {
            if(this.top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("Peek: {0} is in the top of the stack",this.top.data);
            }
        }

        /// <summary>
        /// Pops the top element.
        /// </summary>
        public void PopTopElement()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, can't pop");
            }
            else
            {
                Console.WriteLine("Popped value is: "+this.top.data);
                this.top = this.top.next;
            }
        }

        /// <summary>
        /// UC 2 : Performs Peek and Pop until stack becomes empty
        /// </summary>
        public void IsEmpty()
        {
            while(this.top!=null)
            {
                PeekTopElement();
                PopTopElement();
            }
        }

        /// <summary>
        /// Displays the stack contents from top to bottom.
        /// </summary>
        public void Display()
        {
            Node temp = this.top;
            if(temp==null)
                Console.WriteLine("Stack is empty");
            else
            {
                Console.Write("\nDisplay:Stack contents from top to bottom: ");
                while (temp!=null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
        }
    }
}
