using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public class RemoveNthFromEndLinkedList
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n) {

            ListNode temp = head;
            if (temp == null)
            {
                return null;
            }
             for(int i=0; i< n-1; i++)
            {
                if (temp.next == null || temp == null)
                    return head;
                temp = temp.next;

            }
            temp.next = temp.next.next;






            return head;
        
        
        }
    }
}
