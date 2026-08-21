using System;

namespace LeetCode.Solutions.ContainerWithMostWater;

public class ContainerWithMostWater
{
    public static int Solution(int[] height)
    {
        int max = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right)
        {
            max = Math.Max((right - left) * Math.Min(height[left], height[right]), max);

            if (height[left] > height[right])
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return max;
    }
}
