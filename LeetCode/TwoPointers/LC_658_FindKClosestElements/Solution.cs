using System.Collections.Generic;

namespace LC_658_FindKClosestElements;

/// <summary>
/// Time Complexity: O(n) due to the while loop that iterates to shrink the range, followed by slicing the array.

///Space Complexity: O(k) for storing the result list.
/// </summary>

public class Solution
{
    public IList<int> FindClosestElements(int[] arr, int k, int x)
    {
        int left = 0;
        int right = arr.Length - 1;

        // Shrink the window to find the closest elements
        while (right - left >= k)
        {
            if (Math.Abs(arr[left] - x) > Math.Abs(arr[right] - x))
            {
                left++; // Eliminate the left element if it's farther from x
            }
            else
            {
                right--; // Eliminate the right element if it's farther from x
            }
        }

        // Return the k closest elements and ensure they're sorted
        return arr.Skip(left).Take(k).ToList();
    }
}
