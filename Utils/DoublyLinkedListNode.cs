using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Utils
{
    public class DoublyLinkedListNode<T>
    {
        public T Value;
        public DoublyLinkedListNode<T> Next;
        public DoublyLinkedListNode<T> Prev;

        public DoublyLinkedListNode(T value)
        {
            Value = value;
            Next = null;
            Prev = null;
        }
    }
}
