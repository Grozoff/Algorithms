namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/house-robber/">House Robber</see>
    /// <br>Array, Dynamic Programming</br>
    /// </summary>
    internal class Problem0198
    {
        // not my solution
        public int Rob(int[] nums)
        {
            int prev1 = 0;
            int prev2 = 0;
            foreach (int num in nums)
            {
                int tmp = prev1;
                prev1 = Math.Max(prev2 + num, prev1);
                prev2 = tmp;
            }
            return prev1;
        }
    }
}
