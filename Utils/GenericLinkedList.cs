using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Utils
{
    public class GenericLinkedList<T>
    {
        public GenericNode<T> head;

        public GenericLinkedList()
        {
            head = null;
        }

        public void Add(T item)
        {
            //GenericNode<T> node = new GenericNode<T>( item, null ) ;
            if (head == null)
            {
                head = new GenericNode<T>(item, null);
                return;
            }
            else
            {
                GenericNode<T> temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new GenericNode<T>(item, null);
            }
        }

        public void Remove(T item)
        {
            if (head == null)
            {
                return;
            }

            if (head.Next == null && head.Value.Equals(item))
            {
                head = null;
            }
            if (head.Next == null && head.Value.Equals(item))
            {
                head = head.Next;
            }
            else
            {
                GenericNode<T> temp = head;
                GenericNode<T> prev = null;

                while (temp != null && !temp.Value.Equals(item))
                {
                    prev = temp;
                    temp = temp.Next;

                }

                prev.Next = temp.Next;
            }
        }

        public void Print()
        {
            GenericNode<T> node = head;

            if (node == null)
                return;

            else
                while (node != null)
                {
                    Console.WriteLine(node.Value);
                    node = node.Next;
                }
        }

        public void Print(GenericNode<T> listhead)
        {
            GenericNode<T> node = listhead;

            if (node == null)
                return;

            else
                while (node != null)
                {
                    Console.WriteLine(node.Value);
                    node = node.Next;
                }
        }


        public GenericNode<T> Search(T item)
        {

            if (head == null)
                return null;

            if (head.Value.Equals(item) && head.Next == null)
            {
                return head;
            }
            else
            {
                GenericNode<T> temp = head;
                while (temp.Next != null && !temp.Value.Equals(item))
                {
                    temp = temp.Next;
                }
                return temp;

            }
        }
    }
}
