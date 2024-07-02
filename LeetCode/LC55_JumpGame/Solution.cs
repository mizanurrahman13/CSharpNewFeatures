namespace LC55_JumpGame;

public class Solution
{
    public bool CanJump(int[] nums)
    {
        int finalIndex = nums.Length - 1;

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (i + nums[i] >= finalIndex)
            {
                if (i == 0)
                    return true;
                finalIndex = i;
            }
        }

        return false;
    }

    //public bool CanJump(int[] nums)
    //{
    //    Queue<int> queue = new Queue<int>();
    //    var visited = new bool[nums.Length];
    //    queue.Enqueue(nums.Length - 1);
    //    visited[nums.Length - 1] = true;

    //    while(queue.Count > 0)
    //    {
    //        int index = queue.Dequeue();
    //        if (index == 0)
    //            return true;

    //        for (int i = 0; i < index; i++)
    //        {
    //            if (i + nums[i] >= index && !visited[i])
    //            {
    //                visited[i] = true;
    //                queue.Enqueue(i);
    //            }
    //        }
    //    }

    //    return false;
    //}
}
