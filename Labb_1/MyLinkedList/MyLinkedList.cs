using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{   /// <summary>
/// Class that representas a linked list
/// </summary>
    public class MyLinkedList<T>: IEnumerable<MyNode<T>> ,IListInterface<T>
    {
        private readonly MyNode<T> head;
        private int length;

        public MyLinkedList() 
        {
            head = new MyNode<T>();
            length = 0;
        }

        /// <summary>
        /// method used to get a referens to a node in the list at a given index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="MyLinkedListIndexNotFoundException"></exception>
        private MyNode<T>? GetNodeAttIndex(int index)
        {
            int i = 0;
            MyNode<T> tempNode = null;

            if (head.NextNode != null)
            {
                tempNode = head.NextNode;


                while (i < index)
                {
                    if (tempNode.NextNode != null)
                    {
                        tempNode = tempNode.NextNode;
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (i != index)
                {
                    throw new MyLinkedListIndexNotFoundException();
                }

                return tempNode;
            }

            throw new MyLinkedListIndexNotFoundException();

        }

        /// <summary>
        /// Propery used to get the lenght of the lsit
        /// </summary>
        public int Length { get { return length; } }

        /// <summary>
        /// Makes it posible to use [] indexing
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T? this[int index]
        {
            get {return GetNodeAttIndex(index).Value; }
            set { GetNodeAttIndex(index).Value = value; }
        }

        /// <summary>
        /// Method used to add a item to the beginig off the list 
        /// </summary>
        /// <param name="obj"></param>
        public void AddToStart(T obj)
        {
            MyNode<T> newNode = new MyNode<T>(obj);
            newNode.NextNode = head.NextNode;
            head.NextNode = newNode;
            length++;
        }

        /// <summary>
        /// Method used to add a item to the end off the list
        /// </summary>
        /// <param name="obj"></param>
        public void AddToEnd(T obj) 
        {
            MyNode<T> newNode = new MyNode<T>(obj);

            if (head.NextNode != null) 
            {
                MyNode<T> temp = head.NextNode;

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

        public void AddAtIndex(T obj, int index)
        {
            MyNode<T> newNod = new MyNode<T>(obj);

            if (index < 0 || index > length - 1)
            {
                throw new MyLinkedListIndexNotFoundException($"Index: {index} not found in the list");
            }

            if (index == 0)
            {
                newNod.NextNode = head.NextNode;
                head.NextNode = newNod;
            }
            else
            {
                MyNode<T> tempNode = GetNodeAttIndex(index-1);
                newNod.NextNode = tempNode.NextNode;
                tempNode.NextNode = newNod;
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
                MyNode<T> tempNode = head.NextNode;

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
                MyNode<T> tempNode = GetNodeAttIndex(index-1);
                tempNode.NextNode = tempNode.NextNode.NextNode;
            }
           
            length--;
        }

        /// <summary>
        /// Makes it posible to use foreach loop 
        /// </summary>
        /// <returns></returns>
        public IEnumerator<MyNode<T>> GetEnumerator()
        {
            MyNode<T>? currentNode = head.NextNode;
            while (currentNode is not null)
            {
                yield return currentNode;
                currentNode = currentNode.NextNode;
            }
        }

        /// <summary>
        /// Makes it posible to use foreach loop
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Makes it posible to use foreach loop
        /// </summary>
        /// <returns></returns>
        IEnumerator<MyNode<T>> IEnumerable<MyNode<T>>.GetEnumerator()
        {
            MyNode<T>? currentNode = head.NextNode;
            while (currentNode is not null)
            {
                yield return currentNode;
                currentNode = currentNode.NextNode;
            }
        }

        /// <summary>
        /// Makes it posible to use foreach loop
        /// </summary>
        /// <returns></returns>
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            //throw new NotImplementedException();
            MyNode<T>? currentNode = head.NextNode;
            while (currentNode is not null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.NextNode;
            }
        }






    }





}
