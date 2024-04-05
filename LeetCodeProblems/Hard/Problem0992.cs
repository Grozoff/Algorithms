namespace LeetCodeProblems.Hard
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/subarrays-with-k-different-integers">Subarrays with K Different Integers</see>
    /// <br>Array, Hash Table, Sliding Window, Counting</br>
    /// </summary>
    internal class Problem0992
    {
        public static int SubarraysWithKDistinct(int[] nums, int k)
        {
            return Count(nums, k) - Count(nums, k - 1);
        }

        private static int Count(int[] nums, int k)
        {
            int[] count = new int[nums.Length + 1];
            var result = 0;
            var l = 0;
            for (int r = 0; r < nums.Length; r++)
            {
                if (count[nums[r]] == 0)
                {
                    k--;
                }
                count[nums[r]]++;

                while (k < 0)
                {
                    count[nums[l]]--;
                    if (count[nums[l]] == 0)
                    {
                        k++;
                    }
                    l++;
                }
                result += r - l + 1;
            }

            return result;
        }
    }

    public class Tests0992
    {
        [Test]
        public void Test1()
        {
            int[] s = [1, 2, 1, 2, 3];
            var output = Problem0992.SubarraysWithKDistinct(s, 2);
        }

        [Test]
        public void Test2()
        {
            int[] s = [1, 2, 1, 3, 4];
            var output = Problem0992.SubarraysWithKDistinct(s, 3);
        }
    }
}
