namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/binary-subarrays-with-sum'>Binary Subarrays With Sum</see>
    /// <br>Array, Hash Table, Sliding Window, Prefix Sum</br>
    /// </summary>
    internal class Problem0930
    {
        public int NumSubarraysWithSum(int[] nums, int goal)
        {
            return Count(nums, goal) - Count(nums, goal - 1);
        }

        private int Count(int[] nums, int goal)
        {
            if (goal < 0) return 0;

            var result = 0;
            var left = 0;
            var current = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                current += nums[right];
                while (current > goal)
                {
                    current -= nums[left];
                    left++;
                }
                result += (right - left + 1);
            }

            return result;
        }
    }
}
