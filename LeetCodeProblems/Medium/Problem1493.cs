namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/longest-subarray-of-1s-after-deleting-one-element'>Longest Subarray of 1's After Deleting One Element</see>
    /// <br>Array, Dynamic Programming, Sliding Window</br>
    /// </summary>
    internal class Problem1493
    {
        public int LongestSubarray(int[] nums)
        {
            int maxLength = 0;
            int zeros = 0;
            int start = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeros++;
                }

                while (zeros > 1)
                {
                    if (nums[start] == 0)
                    {
                        zeros--;
                    }

                    start++;
                }

                maxLength = Math.Max(maxLength, i - start);
            }

            return maxLength;
        }
    }
}
