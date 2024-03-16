namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/contiguous-array/'>Contiguous Array</see>
    /// <br>Array, Hash Table, Prefix Sum</br>
    /// </summary>
    internal class Problem0525
    {
        public int FindMaxLength(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            dict.Add(0, -1);
            var diff = 0;
            var result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                diff += (nums[i] == 1 ? 1 : -1);
                if (dict.TryGetValue(diff, out var val))
                {
                    result = Math.Max(result, i - val);
                }
                else
                {
                    dict.Add(diff, i);
                }
            }

            return result;
        }
    }
}
