using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class MyLinkedList : ListInterface
    {
        private MyNode head;
        private int length;

        public MyLinkedList() 
        {
            head = new MyNode();
            length = 0;
        }

        public int Length { get { return length; } }

        public void AddToStart(Object obj)
        {
            MyNode newNode = new MyNode(obj);
            newNode.NextNode = head.NextNode;
            head.NextNode = newNode;
            length++;
        }

        public void AddToEnd(Object obj) 
        {
            MyNode newNode = new MyNode(obj);

            if (head.NextNode != null) 
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

        public void DeleteFirst()
        {
            if (head.NextNode != null) 
            {
                head.NextNode = head.NextNode.NextNode;
                length--;
            }            
        }

        public void DeleteLast() 
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

        private MyNode? GetNodeAttIndex(int index) 
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

        public void DeleteAtIndex(int index)
        {
            if(index < 0 || index > length-1)
            {
                throw new MyLinkedListIndexNotFoundException($"{index} not found in the list");
            }

            if(index ==0) 
            {
                head.NextNode = head.NextNode.NextNode;
            }
            else
            {
                MyNode tempNode = GetNodeAttIndex(index-1);
                tempNode.NextNode = tempNode.NextNode.NextNode;
            }

            length--;
        }

    }

}
