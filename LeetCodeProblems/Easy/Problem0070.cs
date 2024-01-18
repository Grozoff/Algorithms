namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/climbing-stairs'>Climbing Stairs</see>
    /// <br>Math, Dynamic Programming, Memoization</br>
    /// </summary>
    internal class Problem0070
    {
        public int ClimbStairs(int n)
        {
            if (n <= 1) return 1;

            int prev = 0;
            int next = 1;
            for (int i = 0; i < n; i++)
            {
                int sum = prev + next;
                prev = next;
                next = sum;
            }
            return next;
        }
    }
}
