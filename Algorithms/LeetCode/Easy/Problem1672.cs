namespace Algorithms.LeetCode.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/richest-customer-wealth/">Richest Customer Wealth</see>
    /// <br>Array, Matrix</br>
    /// </summary>
    internal class Problem1672
    {
        public int MaximumWealth(int[][] accounts)
        {
            var res = new int[accounts.Length];
            for (var i = 0; i < accounts.Length; i++)
            {
                for (var j = 0; j < accounts[i].Length; j++)
                    res[i] += accounts[i][j];
            }
            return res.Max();
        }
    }
}
