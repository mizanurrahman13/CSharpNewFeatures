namespace LC11_ContainerWithMostWater;

public class Solution
{
    public int MaxArea(int[] height)
    {
        int maxArea = 0;
        int left = 0;
        int right = height.Length-1;
        

        while(left < right)
        {            
            int heightofWater = Math.Min(height[left], height[right]);
            int width = right - left;

            maxArea = Math.Max(maxArea, heightofWater * width);

            if (height[left] < height[right])
                left++;
            else
                right--;
        }

        return maxArea;
    }
}
