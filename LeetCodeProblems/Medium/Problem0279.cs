namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/perfect-squares">Perfect Squares</see>
    /// <br>Math, Dynamic Programming, Breadth-First Search</br>
    /// </summary>
    internal class Problem0279
    {
        public int NumSquares(int n)
        {
            // I hate dp
            int[] dp = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                dp[i] = i;
                for (int j = 1; j * j <= i; j++)
                {
                    dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
                }
            }
            return dp[n];
        }
    }
}
