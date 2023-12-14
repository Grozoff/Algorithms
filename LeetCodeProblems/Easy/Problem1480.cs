namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/running-sum-of-1d-array/">Running Sum of 1d Array</see>
    /// <br>Array, Prefix Sum</br>
    /// </summary>
    internal class Problem1480
    {
        public int[] RunningSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }

            return nums;
        }
    }
}
