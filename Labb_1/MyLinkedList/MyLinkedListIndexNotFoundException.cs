using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class MyLinkedListIndexNotFoundException : Exception
    {
        public MyLinkedListIndexNotFoundException()
        { }

        public MyLinkedListIndexNotFoundException(string message) : base(message)
        { }

        public MyLinkedListIndexNotFoundException(string message, Exception inner) : base(message, inner)
        { }
    }
}
