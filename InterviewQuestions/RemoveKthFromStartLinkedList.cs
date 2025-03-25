using Data_Structures.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public class RemoveKthFromStartLinkedList<T>
    {

        public static GenericNode<T> RemoveKthFromStart(GenericNode<T> head, int k)
        {
            if (head == null) return null; // Edge case: Empty list
            if (k == 1) return head.Next;  // Remove the first node

            GenericNode<T> current = head;
            for (int i = 1; i < k - 1; i++)
            {
                if (current == null || current.Next == null) return head; // If k is out of bounds
                current = current.Next;
            }

            if (current.Next != null)
                current.Next = current.Next.Next; // Skip the K-th node

            return head;
        }
    }

    
}
