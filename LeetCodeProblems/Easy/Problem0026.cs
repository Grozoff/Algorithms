namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/remove-duplicates-from-sorted-array/">Remove Duplicates from Sorted Array</see>
    /// <br>Array, Two Pointers</br>
    /// </summary>
    public class Problem0026
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int uniqueCount = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[uniqueCount] = nums[i];
                    uniqueCount++;
                }
            }

            return uniqueCount;
        }
    }

    public class Tests26
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var input = new[] { 1, 1, 2 };
            var output = Problem0026.RemoveDuplicates(input);

            Assert.That(2, Is.EqualTo(output));
        }

        [Test]
        public void Test2()
        {
            var input = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var output = Problem0026.RemoveDuplicates(input);

            Assert.That(5, Is.EqualTo(output));
        }
    }
}