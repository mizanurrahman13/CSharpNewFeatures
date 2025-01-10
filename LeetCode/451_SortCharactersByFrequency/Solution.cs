using System.Text;

namespace _451_SortCharactersByFrequency;
public class Solution
{
    public string FrequencySort(string s)
    {
        Span<int> frequencies = stackalloc int[75];

        for (int i = 0; i < s.Length; i++)
        {
            frequencies[s[i] - 48]++;
        }

        PriorityQueue<char, int> queue = new PriorityQueue<char, int>();
        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < frequencies.Length; i++)
        {
            if (frequencies[i] > 0)
                queue.Enqueue((char)(i + 48), frequencies[i]);
        }

        while (queue.Count > 0)
        {
            var chr = queue.Dequeue();
            var count = frequencies[chr - 48];
            stringBuilder.Insert(0, new string(chr, count));
        }

        return stringBuilder.ToString();
    }
}
