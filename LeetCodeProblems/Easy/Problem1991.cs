namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/find-the-middle-index-in-array'>Find the Middle Index in Array</see>
    /// <br>Array, Prefix Sum</br>
    /// </summary>
    internal class Problem1991
    {
        public int FindMiddleIndex(int[] nums)
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
