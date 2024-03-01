namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/find-pivot-index'>Find Pivot Index</see>
    /// <br>Array, Prefix Sum</br>
    /// </summary>
    internal class Problem0724
    {
        public int PivotIndex(int[] nums)
        {
            var total = nums.Sum();
            var leftSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var rightSum = total - nums[i] - leftSum;
                if (leftSum == rightSum)
                    return i;
                leftSum += nums[i];
            }
            return -1;
        }
    }
}
