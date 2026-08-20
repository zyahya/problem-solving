namespace LeetCode.Solutions.TwoSumII;

public class TwoSumIITests
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 1, 2 })]
    public void TwoSumII_Solution_1(int[] nums, int target, int[] expectedResult)
    {
        int[] result = TwoSumII.Solution(nums, target);

        Assert.Equal(expectedResult, result);
    }
}
