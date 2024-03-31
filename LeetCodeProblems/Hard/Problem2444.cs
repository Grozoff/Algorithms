namespace LeetCodeProblems.Hard
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/count-subarrays-with-fixed-bounds/">Count Subarrays With Fixed Bounds</see>
    /// <br>Array, Queue, Sliding Window, Monotonic Queue</br>
    /// </summary>
    internal class Problem2444
    {
        public long CountSubarrays(int[] nums, int minK, int maxK)
        {
            long result = 0;
            long maxl = -1;
            long minl = -1;
            long t = -1;
            for (long r = 0; r < nums.Length; r++)
            {
                if (nums[r] < minK || nums[r] > maxK)
                {
                    t = r;
                }
                if (nums[r] == minK)
                {
                    minl = r;
                }
                if (nums[r] == maxK)
                {
                    maxl = r;
                }

                result += Math.Max(0, Math.Min(minl, maxl) - t);
            }

            return result;
        }
    }
}
