using System.Collections.Generic;

namespace LeetCode.Solutions.ThreeSum;

public class ThreeSum
{
    public static IList<IList<int>> Solution(int[] nums)
    {
        int left = 1;
        int right = left + 1;
        IList<IList<int>> triples = [];

        for (int i = 0; i < nums.Length; i++)
        {
            while (left < right)
            {
                if (nums[i] + nums[left] + nums[right] == 0)
                {
                    triples.Add([i, left, right]);
                    continue;
                }

            }
        }

        return triples;
    }
}
