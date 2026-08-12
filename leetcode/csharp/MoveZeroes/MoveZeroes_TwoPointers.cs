namespace LeetCode.Solutions.MoveZeroes;

public class MoveZeroes_TwoPointers
{
    public static int[] Solution(int[] nums)
    {
        int left = 0;
        int right = 0;

        while (right < nums.Length)
        {
            if (nums[left] == 0 && nums[right] != 0)
            {
                (nums[right], nums[left]) = (nums[left], nums[right]);

                left++;
                right++;
                continue;
            }
            else if (nums[left] != 0 && nums[right] == 0)
            {
                left++;
                continue;
            }

            right++;
        }

        return nums;
    }
}
