using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Utils
{
    public class GenericDoubleLinkedList<T>
    {
        public DoublyLinkedListNode<T> head;
        public DoublyLinkedListNode<T> tail;


        public GenericDoubleLinkedList() {
            head = tail = null;

        }

        public void AddLast(T item)
        {
            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(item);

            if (head == null) {
                head = tail = new DoublyLinkedListNode<T>(item, null, null);
                return;
                    }

            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;

            }
        }

        public void AddFirst(T item) {

            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(item);

            if (head == null)
            {
             
                head = tail = newNode;
                return;
            }
            else { 
               newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }

        }

        public void PrintForward()
        {
            DoublyLinkedListNode<T> temp = head;
            while (temp != null)
            {
                Console.Write(temp.Value + " <-> ");
                temp = temp.Next;
            }
            Console.WriteLine("null");
        }

        public void PrintBackward()
        {
            DoublyLinkedListNode<T> temp = tail;
            while (temp != null)
            {
                Console.Write(temp.Value + " <-> ");
                temp = temp.Prev;
            }
            Console.WriteLine("null");
        }
    }
}
