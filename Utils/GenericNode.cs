using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Utils
{
    public class GenericNode<T>
    {
        public T Value;
        public GenericNode<T> Next;

        public GenericNode(T value)
        {
            Value = value;
            Next = null;
        }
    }
}
