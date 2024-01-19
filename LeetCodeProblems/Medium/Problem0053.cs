namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/maximum-subarray'>Maximum Subarray</see>
    /// <br>Array, Divide and Conquer, Dynamic Programming</br>
    /// </summary>
    internal class Problem0053
    {
        public static int MaxSubArray(int[] nums)
        {
            var max = nums[0];
            var currentSumLeft = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (currentSumLeft < 0)
                    currentSumLeft = 0;
                currentSumLeft += nums[i];

                max = Math.Max(max, currentSumLeft);
            }

            return max;
        }
    }

    public class Tests0053
    {
        [Test]
        public void Test()
        {
            int[] input = [-2, 1, -3, 4, -1, 2, 1, -5, 4];
            var output = Problem0053.MaxSubArray(input);

            Assert.That(output, Is.EqualTo(6));
        }
    }
}
