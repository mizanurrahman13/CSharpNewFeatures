using LC_21_MergeTwoSortedLists;

int[] values1 = { 1, 2, 4 };
int[] values2 = { 1, 3, 4 };

ListNode list1 = CreateLinkedList(values1);
ListNode list2 = CreateLinkedList(values2);

Solution solution = new Solution();
ListNode mergedList = solution.MergeTwoLists(list1, list2);

Console.Write("Merged List: ");
PrintLinkedList(mergedList); // Output: 1 1 2 3 4 4
