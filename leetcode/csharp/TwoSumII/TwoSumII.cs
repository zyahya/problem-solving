namespace LeetCode.Solutions.TwoSumII;

public class TwoSumII
{
    public static int[] Solution(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;

        while (left < right)
        {
            if (numbers[left] + numbers[right] > target)
            {
                right--;
                continue;
            }
            else if (numbers[left] + numbers[right] < target)
            {
                left++;
                continue;
            }
            else
            {
                return [left + 1, right + 1];
            }
        }

        return [];
    }
}
