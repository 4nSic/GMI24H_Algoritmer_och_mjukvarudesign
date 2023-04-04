using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    /// <summary>
    /// Class that represents a node to be used in a liked list
    /// </summary>
    public class MyNode<T>
    {
        private T value;
        private MyNode<T>? nextNode;

        public MyNode() { }

        public MyNode(T value)
        {
            this.value = value;
            this.nextNode = null;
        }

        public T Value { get { return value; } set { this.value = value; } }

        public MyNode<T>? NextNode { get { return nextNode; } set { nextNode = value; } }

    }
}
