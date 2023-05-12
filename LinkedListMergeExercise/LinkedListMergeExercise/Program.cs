using LinkedListMergeExercise;
using System.Collections.Generic;

LinkedList<int> list1 = new LinkedList<int>();
list1.AddLast(1);
list1.AddLast(3);
list1.AddLast(5);
list1.AddLast(6);
list1.AddLast(7);

LinkedList<int> list2 = new LinkedList<int>();
list2.AddLast(1);
list2.AddLast(2);
list2.AddLast(4);
list2.AddLast(7);
list2.AddLast(8);

LinkedList<int> merged = LinkedListMerge.MergeLists(list1, list2);

foreach(var node in merged)
    Console.WriteLine(node);