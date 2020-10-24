using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueueUsingLinkedList
{
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
        /// Displays this stack contents from top to bottom.
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
            }
        }
    }
}
