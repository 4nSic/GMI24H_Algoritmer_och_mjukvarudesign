using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class MyLinkedList
    {
        private MyNode head;
        private int length;

        public MyLinkedList() 
        {
            head = new MyNode();
            length = 0;
        }

        public void AddNodeToStart(MyNode newNod)
        {   
            newNod.NextNode = head.NextNode;
            head.NextNode = newNod;
            length++;
        }

        public void AddNodeToEnd(MyNode newNode) 
        {
            if(head.NextNode != null) 
            {
                MyNode temp = head.NextNode;

                while (temp.NextNode != null)
                {
                    temp = temp.NextNode;
                }
                
                temp.NextNode = newNode;
            }
            else
            {
                head.NextNode = newNode;
            }

            length++;

        }

        public void FlushList()
        {
            head.NextNode = null;
            length = 0;
        }

        public void DeleteFirstNode()
        {
            if (head.NextNode != null) 
            {
                head.NextNode = head.NextNode.NextNode;
                length--;
            }            
        }

        public void DeleteLastNode() 
        {   
            if(head.NextNode != null && head.NextNode.NextNode != null)
            {
                MyNode tempNode = head.NextNode;

                while (tempNode.NextNode != null && tempNode.NextNode.NextNode != null)
                {
                    tempNode = tempNode.NextNode;
                }

                tempNode.NextNode = null;
            }
            else
            {
                head.NextNode=null;
            }

            length--;
        }

        public MyNode? GetNodeAttIndex(int index) 
        {
            int i = 0;
            MyNode tempNode = null;

            if(head.NextNode != null) 
            {
                tempNode=head.NextNode;
                while(i < index) 
                {
                    if(tempNode.NextNode != null)
                    {
                        tempNode = tempNode.NextNode;
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }

                if(i != index)
                {
                    throw new IndexOutOfRangeException();
                }

                return tempNode;
            }

            throw new IndexOutOfRangeException();
            
        }

    }

    public class MyLinkedListIndexNotFoundException : Exception 
    {
        public MyLinkedListIndexNotFoundException()
        { }

        public MyLinkedListIndexNotFoundException(string message): base(message) 
        { }

        public MyLinkedListIndexNotFoundException(string message, Exception inner): base(message, inner) 
        { }
    }

}
