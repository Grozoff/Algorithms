namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/set-mismatch">Set Mismatch</see>
    /// <br>Array, Hash Table, Bit Manipulation, Sorting</br>
    /// </summary>
    internal class Problem0645
    {
        public static int[] FindErrorNums(int[] nums)
        {
            var hs = new HashSet<int>();
            var expectedSum = (nums.Length * (nums.Length + 1)) / 2;
            var actualSum = 0;
            var duplicate = 0;
            foreach (var n in nums)
            {
                if (!hs.Add(n))
                {
                    duplicate = n;
                }
                actualSum += n;
            }
            var missingNumber = expectedSum - (actualSum - duplicate);
            return [duplicate, missingNumber];
        }
    }

    public class Tests0645
    {

        [Test]
        public void Test1()
        {
            int[] input = [1, 2, 2, 4];
            var output = Problem0645.FindErrorNums(input);
        }
    }
}
