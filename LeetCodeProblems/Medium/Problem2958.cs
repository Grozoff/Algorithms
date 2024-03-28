namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/length-of-longest-subarray-with-at-most-k-frequency">Length of Longest Subarray With at Most K Frequency</see>
    /// <br>Array, Hash Table, Sliding Window</br>
    /// </summary>
    internal class Problem2958
    {
        public static int MaxSubarrayLength(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            var l = 0;
            var result = 1;
            for (int r = 0; r < nums.Length; r++)
            {
                if (dict.TryGetValue(nums[r], out int value))
                {
                    dict[nums[r]] = ++value;
                }
                else
                {
                    dict[nums[r]] = 1;
                }

                while (dict[nums[r]] > k)
                {
                    dict[nums[l]]--;
                    l++;
                }
                result = Math.Max(result, r - l + 1);
            }

            return result;
        }
    }

    public class Tests2958
    {
        [Test]
        public void Test1()
        {
            int[] s = [1, 2, 3, 1, 2, 3, 1, 2];
            var output = Problem2958.MaxSubarrayLength(s, 2);
        }

        [Test]
        public void Test2()
        {
            int[] s = [1, 2, 1, 2, 1, 2, 1, 2];
            var output = Problem2958.MaxSubarrayLength(s, 1);
        }

        [Test]
        public void Test3()
        {
            int[] s = [1, 2, 2, 2];
            var output = Problem2958.MaxSubarrayLength(s, 1);
        }
    }
}
