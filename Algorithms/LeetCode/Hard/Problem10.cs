namespace Algorithms.LeetCode.Hard
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/regular-expression-matching/description/">Regular Expression Matching</see>
    /// <br>String, Dynamic Programming, Recursion</br>
    /// </summary>
    internal class Problem10
    {
        public bool IsMatch(string s, string p)
        {
            int m = s.Length, n = p.Length;
            bool[,] dp = new bool[m + 1, n + 1];
            dp[0, 0] = true;
            for (int j = 1; j <= n; j++)
            {
                if (p[j - 1] == '*')
                {
                    dp[0, j] = dp[0, j - 2];
                }
            }
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (p[j - 1] == '.' || p[j - 1] == s[i - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else if (p[j - 1] == '*')
                    {
                        dp[i, j] = dp[i, j - 2];
                        if (p[j - 2] == '.' || p[j - 2] == s[i - 1])
                        {
                            dp[i, j] = dp[i, j] || dp[i - 1, j];
                        }
                    }
                    else
                    {
                        dp[i, j] = false;
                    }
                }
            }
            return dp[m, n];
        }
    }
}
