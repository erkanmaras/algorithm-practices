namespace AlgorithmPractice.ArrayAndHashing;

public class ValidAnagram
{
    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "car", false)]
    [InlineData("raat", "ratt", false)]
    public void Test(string first, string second, bool expected)
    {
        Solution(first, second).Should().Be(expected);
    }

    private static bool Solution(string first, string second)
    {
        if (first.Length != second.Length)
        {
            return false;
        }

        var firstCounts = new Dictionary<char, int>();
        var secondCounts = new Dictionary<char, int>();

        for (int i = 0; i < first.Length; i++)
        {
            var fkey = first[i];
            var skey = second[i];

            firstCounts.TryGetValue(fkey, out var fValue);
            secondCounts.TryGetValue(skey, out var sValue);
            firstCounts[fkey] = fValue + 1;
            secondCounts[skey] = sValue + 1;
        }

        foreach (var f in first)
        {
            firstCounts.TryGetValue(f, out var fValue);
            secondCounts.TryGetValue(f, out var sValue);
            
            if (fValue != sValue)
            {
                return false;
            }
        }
        
        return true;
    }
}