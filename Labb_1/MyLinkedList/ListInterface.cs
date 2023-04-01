using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public interface ListInterface
    {
        public void AddToStart(Object newNod);
        public void AddToEnd(Object newNode);
        public void FlushList();
        public void DeleteFirst();
        public void DeleteLast();
        public void DeleteAtIndex(int index);
    }
}
