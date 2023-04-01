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
    public class MyNode
    {         
        private Object? value;
        private MyNode? nextNode;

        public MyNode() { nextNode = null; value = null; }

        public MyNode(object value)
        {
            this.value = value;
            this.nextNode = null;
        }

        public Object? Value { get { return value; } set { this.value = value; } }

        public MyNode? NextNode { get { return nextNode; } set { nextNode = value; } }


    }
}
