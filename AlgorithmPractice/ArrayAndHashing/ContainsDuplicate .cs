


namespace AlgorithmPractice.ArrayAndHashing;

public class ContainsDuplicate
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 1 }, true)]
    [InlineData(new[] { 1, 2, 3, 4 }, false)]
    [InlineData(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    public void Test(int[] input, bool expected)
    {
        Solution(input).Should().Be(expected);
    }
    
    private static bool Solution(int[] nums)
    {
        var hashSet = new HashSet<int>();
        foreach (var num in nums)
        {
            if (!hashSet.Add(num))
            {
                return true;
            }
        }

        return false;
    }
}