namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/count-subarrays-where-max-element-appears-at-least-k-times">Count Subarrays Where Max Element Appears at Least K Times</see>
    /// <br>Array, Sliding Window</br>
    /// </summary>
    internal class Problem2962
    {
        public static long CountSubarrays(int[] nums, int k)
        {
            var max = nums.Max();
            long result = 0;
            long l = 0;
            for (long r = 0; r < nums.Length; r++)
            {
                if (nums[r] == max)
                {
                    k--;
                }
                while (k == 0)
                {
                    if (nums[l] == max)
                    {
                        k++;
                    }
                    l++;
                }
                result += l;
            }

            return result;
        }
    }

    public class Tests2962
    {
        [Test]
        public void Test1()
        {
            int[] s = [1, 3, 2, 3, 3];
            var output = Problem2962.CountSubarrays(s, 2);
        }

        [Test]
        public void Test2()
        {
            int[] s = [1, 4, 2, 1];
            var output = Problem2962.CountSubarrays(s, 3);
        }
    }
}
