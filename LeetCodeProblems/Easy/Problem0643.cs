namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/maximum-average-subarray-i">Maximum Average Subarray I</see>
    /// <br>Array, Sliding Window</br>
    /// </summary>
    internal class Problem0643
    {
        public static double FindMaxAverage(int[] nums, int k)
        {
            if (nums.Length <= k)
            {
                return nums.Sum() / (double)k;
            }
            else
            {
                var left = 0;
                var right = k-1;
                var maxSum = nums[..k].Sum();
                var sum = maxSum;
                while (right < nums.Length-1)
                {
                    sum = sum - nums[left] + nums[right + 1];
                    maxSum = Math.Max(sum, maxSum);
                    left++;
                    right++;
                }

                return maxSum / (double)k;
            }

            // not my solution
            int summ = 0;
            for (int i = 0; i < k; i++)
            {
                summ += nums[i];
            }

            int maxSumm = summ;
            for (int i = k; i < nums.Length; i++)
            {
                summ += nums[i] - nums[i - k];
                maxSumm = Math.Max(maxSumm, summ);
            }

            return (double)maxSumm / k;
        }
    }

    public class Tests1679
    {
        [Test]
        public void Test1()
        {
            int[] input = [1, 12, -5, -6, 50, 3];
            var k = 4;
            var output = Problem0643.FindMaxAverage(input, k);
            Assert.True(output == 12.75);
        }

        [Test]
        public void Test11()
        {
            int[] input = [9, 7, 3, 5, 6, 2, 0, 8, 1, 9];
            var k = 6;
            var output = Problem0643.FindMaxAverage(input, k);
            Assert.True(output == 5.33333);
        }

        [Test]
        public void Test2()
        {
            int[] input = [4, 0, 4, 3, 3];
            var k = 5;
            var output = Problem0643.FindMaxAverage(input, k);
            Assert.True(output == 14);
        }
    }
}
