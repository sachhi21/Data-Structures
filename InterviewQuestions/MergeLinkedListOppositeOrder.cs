using Data_Structures.Utils;
using System;

namespace Data_Structures.InterviewQuestions
{
    public class MergeLinkedListOppositeOrder<T>
    {
        // Merge the two lists, with list2 being reversed and added after each element of list1
        public static GenericLinkedList<T> MergeLinkedListOpposite(GenericLinkedList<T> list1, GenericLinkedList<T> list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            // Reverse list2
            list2 = Reverse(list2);

            GenericLinkedList<T> result = new GenericLinkedList<T>();

            GenericNode<T> Head = list1.head;
            GenericNode<T> Tail = list2.head;

            while (Head != null || Tail != null)
            {
                if (Head != null)
                {
                    result.Add(Head.Value);
                    Head = Head.Next;
                }

                // Add from list2 if available
                if (Tail != null)
                {
                    result.Add(Tail.Value);
                    Tail = Tail.Next;
                }
            }

            return result;
        }

        // Method to reverse the linked list
        public static GenericLinkedList<T> Reverse(GenericLinkedList<T> list)
        {
            if (list == null || list.head == null) return list;

            GenericNode<T> prev = null;
            GenericNode<T> current = list.head;
            GenericNode<T> next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            list.head = prev; 
            return list;
        }
    }
}
