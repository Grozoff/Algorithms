namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/subarray-product-less-than-k">Subarray Product Less Than K</see>
    /// <br>Array, Sliding Window</br>
    /// </summary>
    internal class Problem0713
    {
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            var result = 0;
            var l = 0;
            var p = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                p *= nums[i];
                while (l <= i && p >= k)
                {
                    p /= nums[l];
                    l++;
                }
                result += i - l + 1;
            }

            return result;
        }
    }
}
