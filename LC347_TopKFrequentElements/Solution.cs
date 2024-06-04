namespace LC347_TopKFrequentElements;

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> mapFrequence = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (mapFrequence.ContainsKey(nums[i]))
                mapFrequence[nums[i]]++;
            else
                mapFrequence[nums[i]] = 1;
        }

        PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();
        foreach (int key in mapFrequence.Keys)
        {
            priorityQueue.Enqueue(key, mapFrequence[key]);

            if (priorityQueue.Count > k )
                priorityQueue.Dequeue();
        }

        int[] result = new int[k];
        int temp = k;

        while (priorityQueue.Count > 0)
            result[--temp] = priorityQueue.Dequeue();

        return result;
    }
}
