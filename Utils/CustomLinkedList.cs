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

        public void add(object value)
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
                    Incident incident = new Incident();
                    incident = (Incident)root.Value;
                    Console.WriteLine(incident.IncidentName);
                    root = root.Next;
                }
            }
        }
    }
}
