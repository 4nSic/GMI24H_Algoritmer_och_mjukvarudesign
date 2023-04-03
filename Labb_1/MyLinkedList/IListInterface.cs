using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{   /// <summary>
/// interface used to define methods that shuold be posibel tu use whit a list
/// </summary>
    public interface IListInterface<T> : IEnumerable<T>
    {
        public void AddToStart(T value);
        public void AddToEnd(T value);
        public void FlushList();
        public void DeleteFirst();
        public void DeleteLast();
        public void DeleteAtIndex(int index);
    }
}
