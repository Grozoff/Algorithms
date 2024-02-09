namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/largest-divisible-subset">Largest Divisible Subset</see>
    /// <br>Array, Math, Dynamic Programming, Sorting</br>
    /// </summary>
    internal class Problem0368
    {
        public IList<int> LargestDivisibleSubset(int[] nums)
        {
            var result = new List<int>();
            if (nums == null || nums.Length == 0) return result;

            Array.Sort(nums);
            int n = nums.Length;
            int[] dp = new int[n];
            int[] prev = new int[n];
            int maxIndex = 0;
            int maxSize = 0;

            for (int i = 0; i < n; i++)
            {
                dp[i] = 1;
                prev[i] = -1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (nums[i] % nums[j] == 0 && dp[j] + 1 > dp[i])
                    {
                        dp[i] = dp[j] + 1;
                        prev[i] = j;
                    }
                }
                if (dp[i] > maxSize)
                {
                    maxSize = dp[i];
                    maxIndex = i;
                }
            }

            while (maxIndex != -1)
            {
                result.Add(nums[maxIndex]);
                maxIndex = prev[maxIndex];
            }

            return result;
        }
    }
}
