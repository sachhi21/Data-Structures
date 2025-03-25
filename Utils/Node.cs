using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Utils
{
    public class Node
    {
        public object Value;
        public Node Next;
        public Node(object value, Node next) {
           Value = value;
            Next = next;
        }
    }
}
