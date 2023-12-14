namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/single-number/">Single Number</see>
    /// <br>Array, Bit Manipulation</br>
    /// </summary>
    internal class Problem136
    {
        public int SingleNumber(int[] nums)
        {
            var result = 0;

            foreach (var x in nums)
            {
                result ^= x;
            }

            return result;
        }
    }
}
