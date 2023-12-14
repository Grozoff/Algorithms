namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/two-sum/">Two Sum</see>
    /// <br>Array, Hash Table</br>
    /// </summary>
    internal class Problem1
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var set = new Dictionary<int, int>();
            int number = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.ContainsKey(nums[i]))
                    return new[] { set[nums[i]], i };

                number = target - nums[i];
                if (!set.ContainsKey(number)) set.Add(number, i);
            }

            return new int[2];
        }
    }

    public class Tests1
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var numst = new[] { 2, 7, 11, 15 };
            var target = 9;
            var output = Problem1.TwoSum(numst, target);

            Assert.That(new[] { 0, 1 }, Is.EqualTo(output));
        }

        [Test]
        public void Test2()
        {
            var numst = new[] { 3, 2, 4 };
            var target = 6;
            var output = Problem1.TwoSum(numst, target);

            Assert.That(new[] { 1, 2 }, Is.EqualTo(output));
        }

        [Test]
        public void Test3()
        {
            var numst = new[] { 3, 3 };
            var target = 6;
            var output = Problem1.TwoSum(numst, target);

            Assert.That(new[] { 0, 1 }, Is.EqualTo(output));
        }
    }
}
