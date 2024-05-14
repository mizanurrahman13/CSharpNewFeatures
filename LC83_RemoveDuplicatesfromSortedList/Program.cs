using LC83_RemoveDuplicatesfromSortedList;

Solution solution = new Solution();
LinkedList<int> list = new LinkedList<int>();
list.AddLast(1);
list.AddLast(1);
list.AddLast(2);
list.AddLast(3);
list.AddLast(4);
Console.WriteLine(solution.DeleteDuplicates(list));
