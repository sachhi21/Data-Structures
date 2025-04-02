using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public class StackArray<T>
    {
        object[] array;
        int size;
        int top;
        public Boolean isFull()
        {
            return top == size - 1;
        }

        public Boolean isEmpty()
        {
            return top == -1;
        }

        public StackArray(int arraySize)
        {
            size = arraySize;
            array = new object[size];
            top = -1;
        }

        public void Push(object value) {

            if(isFull())
            {
                return;
            }
            top = top + 1;
            array[top] = value;
        }

        public T pop()
        {

            if (isEmpty())
            {
                return default(T);
            }
            T item = (T) array[top];
            top = top - 1;
            return item;
             
        }

       
    }
}
