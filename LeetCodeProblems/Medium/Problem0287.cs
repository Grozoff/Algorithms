namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/find-the-duplicate-number">Find the Duplicate Number</see>
    /// <br>Array, Two Pointers, Binary Search, Bit Manipulation</br>
    /// </summary>
    internal class Problem0287
    {
        public int FindDuplicate(int[] nums)
        {
            var buffer = new bool[nums.Length];
            foreach (var num in nums)
            {
                if (buffer[num - 1])
                {
                    return num;
                }
                buffer[num - 1] = true;
            }
            return -1;
        }
    }
}
