using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Utils
{
    public class Node
    {
        public Incident Value;
        public Node Next;
        public Node(Incident value) {
           Value = value;
            Next = null;
        }
    }
}
