using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    public static class IndicesAndRangesDemo
    {
        public static void Demo()
        {
            // places[0] = "first"
            // places[4] = "fifth"
            // places[places.Length - 1] = "fifth"
            var places = new string[] { "first", "second", "third", "forth", "fifth" };

            Console.WriteLine($"The last item in the list is {places[^1]}");
            Console.WriteLine($"The second to last item in the list is {places[^2]}");

            Console.WriteLine();

            Console.WriteLine("places 2 and 3 - 2..4 indicates index position 2 (item 3) up until 4 (not including it)");
            foreach (var item in places[2..4])
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("places 1, 2 and 3 - 1..^1 indicates index position 1 (item 2) up until the last item (not including it)");
            foreach (var item in places[1..^1])
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("places 0, 1, 2 and 3 - ..^1 indicates everything up until the last item (not including it)");
            foreach (var item in places[..^1])
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("places 1, 2, 3 and 4 - 1.. indicates index position 1 (item 2) through the end of the string");
            foreach (var item in places[1..])
            {
                Console.WriteLine(item);
            }
        }
    }
}
