namespace Algorithms.LeetCode.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/contains-duplicate/">Contains Duplicate</see>
    /// <br>Array, Hash Table, Sorting</br>
    /// </summary>
    internal class Problem217
    {
        public bool ContainsDuplicate(int[] nums)
        {
            return nums.ToHashSet().Count < nums.Length;
        }
    }
}
