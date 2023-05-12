using System.Collections.Generic;

namespace LinkedListMergeExercise;

public static class LinkedListMerge
{
    public static LinkedList<int> MergeLists(LinkedList<int> list1, LinkedList<int> list2)
    {
        LinkedListNode<int> head1 = list1.First;
        LinkedListNode<int> head2 = list2.First;

        if (head1 == null)
            return list2;

        if (head2 == null)
            return list1;

        LinkedList<int> mergedList = new LinkedList<int>();
        LinkedListNode<int> currentMerged;

        if (head1.Value < head2.Value)
        {
            mergedList.AddLast(head1.Value);
            currentMerged = mergedList.Last;
            head1 = head1.Next;
        }
        else
        {
            mergedList.AddLast(head2.Value);
            currentMerged = mergedList.Last;
            head2 = head2.Next;
        }

        while (head1 != null && head2 != null)
        {
            if (head1.Value <= head2.Value)
            {
                mergedList.AddLast(head1.Value);
                currentMerged = currentMerged.Next;
                head1 = head1.Next;
            }
            else
            {
                mergedList.AddLast(head2.Value);
                currentMerged = currentMerged.Next;
                head2 = head2.Next;
            }
        }

        while (head1 != null)
        {
            mergedList.AddLast(head1.Value);
            currentMerged = currentMerged.Next;
            head1 = head1.Next;
        }

        while (head2 != null)
        {
            mergedList.AddLast(head2.Value);
            currentMerged = currentMerged.Next;
            head2 = head2.Next;
        }

        return mergedList;
    }
}
