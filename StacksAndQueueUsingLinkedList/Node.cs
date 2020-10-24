// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Node.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Aseem Anand"/>
// --------------------------------------------------------------------------------------------------------------------

namespace StacksAndQueueUsingLinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
