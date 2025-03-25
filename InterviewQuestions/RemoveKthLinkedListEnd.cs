using Data_Structures.Utils;

public static class RemoveKthLinkedListEnd<T>
{
    public static GenericNode<T> RemoveKthFromEndFromLinkedList(GenericNode<T> head, int k)
    {
        if (head == null) return null;

        GenericNode<T> slowPtr = head;
        GenericNode<T> fastPtr = head;

        for (int i = 0; i < k; i++)
        {
            if (fastPtr == null) return head; // If k > length of list, return unchanged list
            fastPtr = fastPtr.Next;
        }

        if (fastPtr == null) return head.Next;

        while (fastPtr.Next != null)
        {
            slowPtr = slowPtr.Next;
            fastPtr = fastPtr.Next;
        }

        // Remove the k-th node
        slowPtr.Next = slowPtr.Next.Next;

        return head;
    }
}
