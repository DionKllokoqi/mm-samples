namespace LinkedListReverse;

public class LinkedListReversal<T>
{
    /// <summary>
    /// Reverses linked list via swapping in O(n).
    /// </summary>
    /// <param name="linkedList">A .NET linked list.</param>
    /// <typeparam name="T"></typeparam>
    public void ReverseLinearly(LinkedList<T> linkedList)
    {
        LinkedListNode<T>? firstNode = linkedList.First;
        LinkedListNode<T>? lastNode = linkedList.Last;

        int numberOfIterations = linkedList.Count / 2;

        object? tmpValueHolder;
        for (int i = 0; i < numberOfIterations; i++)
        {
            tmpValueHolder = firstNode!.Value;
            firstNode.Value = lastNode!.Value;
            lastNode.Value = (T)tmpValueHolder!;

            firstNode = firstNode.Next;
            lastNode = lastNode.Previous;
        }
    }

    /// <summary>
    /// Reverses linked list via recursion in O(n).
    /// </summary>
    /// <param name="linkedList"></param>
    public void ReverseRecursively(LinkedList<T> linkedList)
    {
        ReverseRecursivelyUtil(linkedList.First, linkedList);
    }

    /// <summary>
    /// Method removes all the elements in the linked list by following the
    /// next pointer, and adds them backwards in a recursive manner.
    /// </summary>
    /// <param name="curr">Current linked list node in the recursion.</param>
    /// <param name="linkedList">Linked List to be reversed recursively.</param>
    private void ReverseRecursivelyUtil(LinkedListNode<T>? curr, LinkedList<T> linkedList)
    { 
        if (curr!.Next == null)
        {
            return;
        }

        linkedList.RemoveFirst();
        ReverseRecursivelyUtil(linkedList.First, linkedList);
        linkedList.AddLast(curr);
    }
}
