using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Utils
{
    public class CustomLinkedList
    {

        Node Head;

        public CustomLinkedList() {
            Head = null;
        }

        public void add(Incident value)
        {
            Node root = new Node(value, null);
            if (Head == null)
            {
                Head = root;
            }
            else
            {
                Node temp = Head;
                while (temp.Next != null)
                {
                    temp = Head.Next;
                }

                temp.Next = root;

            }
        }

        public void print()
        {
            Node root = Head;
            if(Head == null)
            {
                Console.WriteLine("Empty Linkedlist");
            }
            else
            {
                while (root != null )
                {
                    //Incident incident = new Incident();
                    //incident = (Incident)root.Value;
                    Console.WriteLine(root.Value.IncidentName);
                    root = root.Next;
                }
            }
        }

        public Node Search(Incident item)
        {

            if (Head == null)
                return null;

            if (Head.Value.Equals(item) && Head.Next == null)
            {
                return Head;
            }
            else
            {
                Node temp = Head;
                while (temp.Next != null && !temp.Value.Equals(item))
                {
                    temp = temp.Next;
                }
                return temp;

            }
        }

        public void Remove(Incident item)
        {
            if (Head == null)
            {
                return;
            }

            if (Head.Next == null && Head.Value.Id.Equals(item.Id))
            {
                Head = null;
            }

            if (Head.Next != null && Head.Value.Id.Equals(item.Id))
            {
                Head = Head.Next;
            }
            else
            {
                Node temp = Head;
               Node prev = null;

                while (temp != null && !temp.Value.Equals(item))
                {
                    prev = temp;
                    temp = temp.Next;

                }

                prev.Next = temp.Next;
            }
        }
    }
}
