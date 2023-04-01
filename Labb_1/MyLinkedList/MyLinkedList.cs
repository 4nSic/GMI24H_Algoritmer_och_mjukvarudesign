using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{   /// <summary>
/// Class that representas a linked list
/// </summary>
    public class MyLinkedList : ListInterface
    {
        private MyNode head;
        private int length;

        public MyLinkedList() 
        {
            head = new MyNode();
            length = 0;
        }

        /// <summary>
        /// Propery used to get the lenght of the lsit
        /// </summary>
        public int Length { get { return length; } }

        /// <summary>
        /// Method used to add a item to the beginig off the list 
        /// </summary>
        /// <param name="obj"></param>
        public void AddToStart(Object obj)
        {
            MyNode newNode = new MyNode(obj);
            newNode.NextNode = head.NextNode;
            head.NextNode = newNode;
            length++;
        }

        /// <summary>
        /// Method used to add a item to the end off the list
        /// </summary>
        /// <param name="obj"></param>
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

        /// <summary>
        /// Method used to empty the lsit
        /// </summary>
        public void FlushList()
        {
            head.NextNode = null;
            length = 0;
        }

        /// <summary>
        /// Methof used to remove a item from the begining of the list 
        /// </summary>
        public void DeleteFirst()
        {
            if (head.NextNode != null) 
            {
                head.NextNode = head.NextNode.NextNode;
                length--;
            }            
        }

        /// <summary>
        /// Methof used to remove a item from the end of the list
        /// </summary>
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

        /// <summary>
        /// method used to get a referens to a node in the list at a given index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
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

        /// <summary>
        /// Method used to delete a item at a given index in the lsit
        /// </summary>
        /// <param name="index"></param>
        /// <exception cref="MyLinkedListIndexNotFoundException"></exception>
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
