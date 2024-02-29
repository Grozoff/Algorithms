namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/max-consecutive-ones'>Max Consecutive Ones</see>
    /// <br>Array</br>
    /// </summary>
    internal class Problem0485
    {
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            var max = 0;
            var maxResult = 0;
            var l = 0;
            while (l < nums.Length)
            {
                if (nums[l] != 1)
                {
                    l++;
                    max = 0;
                }
                else
                {
                    l++;
                    max++;
                }

                maxResult = Math.Max(maxResult, max);
            }

            return maxResult;

            // not my solution
            int res = 0;
            int temp = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    temp++;
                }
                else
                {
                    res = Math.Max(res, temp);
                    temp = 0;
                }
            }

            return Math.Max(res, temp);
        }
    }

    public class Tests0485
    {

        [Test]
        public void Test1()
        {
            int[] input = [1, 1, 0, 1, 1, 1];
            var output = Problem0485.FindMaxConsecutiveOnes(input);
            Assert.That(output, Is.EqualTo(3));
        }

        [Test]
        public void Test2()
        {
            int[] input = [1, 0, 1, 1, 0, 1];
            var output = Problem0485.FindMaxConsecutiveOnes(input);
            Assert.That(output, Is.EqualTo(2));
        }

        [Test]
        public void Test3()
        {
            int[] input = [0, 0];
            var output = Problem0485.FindMaxConsecutiveOnes(input);
            Assert.That(output, Is.EqualTo(0));
        }
    }
}
