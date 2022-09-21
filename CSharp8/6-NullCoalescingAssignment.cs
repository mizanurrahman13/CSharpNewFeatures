using System;
using System.Collections.Generic;

namespace CSharp8
{
    public static class NullCoalescingAssignmentDemo
    {
        public static void Demo()
        {
            var example = new ListDemo();

            //if (example.LuckyNumbers == null)
            //    example.LuckyNumbers = new List<int>();

            example.LuckyNumbers ??= new List<int>();

            example.LuckyNumbers.Add(15);

            foreach (var item in example.LuckyNumbers)
            {
                Console.WriteLine($"Lucky Number: { item }");
            }
        }

        public class ListDemo
        {
            public List<int> LuckyNumbers { get; set; }
            public ListDemo()
            {
                LuckyNumbers = new List<int> { 21 };
            }
        }
    }
}
