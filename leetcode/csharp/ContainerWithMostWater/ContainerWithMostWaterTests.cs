namespace LeetCode.Solutions.ContainerWithMostWater;

public class ContainerWithMostWaterTests
{
    [Fact]
    public void ContainerWithMostWater_Solution_1()
    {
        int result = ContainerWithMostWater.Solution([1, 8, 6, 2, 5, 4, 8, 3, 7]);

        Assert.Equal(49, result);
    }
}
