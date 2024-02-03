namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/partition-array-for-maximum-sum'>Partition Array for Maximum Sum</see>
    /// <br>Array, Dynamic Programming</br>
    /// </summary>
    internal class Problem1043
    {
        public int MaxSumAfterPartitioning(int[] arr, int k)
        {
            // not my solution
            int n = arr.Length;
            int[] dp = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                int maxVal = 0;
                for (int j = 1; j <= k && i - j >= 0; j++)
                {
                    maxVal = Math.Max(maxVal, arr[i - j]);
                    dp[i] = Math.Max(dp[i], dp[i - j] + maxVal * j);
                }
            }

            return dp[n];
        }
    }
}
