namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/increasing-triplet-subsequence'>Increasing Triplet Subsequence</see>
    /// <br>Array, Greedy</br>
    /// </summary>
    internal class Problem0334
    {
        public static bool IncreasingTriplet(int[] nums)
        {
            if (nums.Length < 3)
            {
                return false;
            }

            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            foreach (int num in nums)
            {
                if (num < smallest)
                {
                    smallest = num;
                }
                else if (num < secondSmallest)
                {
                    secondSmallest = num;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }

    public class Tests0334
    {
        [Test]
        public void Test1()
        {
            int[] s = [20, 100, 10, 12, 5, 13];
            var output = Problem0334.IncreasingTriplet(s);
            Assert.True(output);
        }

        [Test]
        public void Test2()
        {
            int[] s = [1, 6, 2, 5, 1];
            var output = Problem0334.IncreasingTriplet(s);
            Assert.True(output);
        }

        [Test]
        public void Test3()
        {
            int[] s = [2, 1, 5, 0, 3];
            var output = Problem0334.IncreasingTriplet(s);
            Assert.False(output);
        }

        [Test]
        public void Test4()
        {
            int[] s = [4, 5, 2147483647, 1, 2];
            var output = Problem0334.IncreasingTriplet(s);
            Assert.True(output);
        }
    }
}
