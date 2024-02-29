namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/max-consecutive-ones-iii'>Max Consecutive Ones III</see>
    /// <br>Array, Binary Search, Sliding Window, Prefix Sum</br>
    /// </summary>
    internal class Problem1004
    {
        public static int LongestOnes(int[] nums, int k)
        {
            // not my weird solution
            int startIndex = 0;
            int endIndex = 0;

            while (endIndex < nums.Length)
            {
                if (nums[endIndex] == 0) --k;

                if (k < 0)
                {
                    k += 1 - nums[startIndex++];
                }
                ++endIndex;
            }

            return endIndex - startIndex;

            // not my simple solution
            int maxLength = 0;
            int zeros = 0;
            int start = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeros++;
                }

                while (zeros > k)
                {
                    if (nums[start] == 0)
                    {
                        zeros--;
                    }

                    start++;
                }

                maxLength = Math.Max(maxLength, i - start + 1);
            }

            return maxLength;

            // my spaghetti code solution
            if (nums.Length <= k)
                return nums.Length;

            var p1 = 0;
            var p2 = 0;
            var zeroes = new HashSet<int>();
            var result = 0;
            var max = 0;
            while (p2 < nums.Length && p1 < nums.Length)
            {
                if(k == 0)
                {
                    if (nums[p1] == 1)
                    {
                        max++;
                    }
                    else
                    {
                        result = Math.Max(result, max);
                        max = 0;
                    }
                    p1++;
                }
                else
                {
                    if (nums[p1] != 1 && zeroes.Count == 0)
                    {
                        zeroes.Add(p1);
                        p2++;
                        max++;
                    }
                    else if (nums[p2] == 1)
                    {
                        p2++;
                        max++;
                    }
                    else if (nums[p2] == 0 && zeroes.Count < k)
                    {
                        zeroes.Add(p2);
                        p2++;
                        max++;

                    }
                    else
                    {
                        zeroes.Remove(p1);
                        p1++;
                        max--;
                    }
                    result = Math.Max(result, max);
                }
            }

            return result;
        }
    }

    public class Tests1004
    {

        [Test]
        public void Test1()
        {
            int[] input = [1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0];
            var output = Problem1004.LongestOnes(input, 2);
            Assert.That(output, Is.EqualTo(6));
        }

        [Test]
        public void Test2()
        {
            int[] input = [0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1];
            var output = Problem1004.LongestOnes(input, 3);
            Assert.That(output, Is.EqualTo(10));
        }

        [Test]
        public void Test3()
        {
            int[] input = [0, 0, 1, 1, 1, 0, 0];
            var output = Problem1004.LongestOnes(input, 0);
            Assert.That(output, Is.EqualTo(3));
        }
    }
}
