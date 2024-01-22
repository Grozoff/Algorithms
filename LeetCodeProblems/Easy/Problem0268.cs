namespace LeetCodeProblems.Easy
{
    internal class Problem0268
    {
        public static int MissingNumber(int[] nums)
        {
            return (nums.Length * (nums.Length + 1) / 2) - nums.Sum();

            // not my solution
            int x = nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                x = x ^ i ^ nums[i];
            }

            return x;
        }
    }

    public class Tests0268
    {
        [Test]
        public void Test1()
        {
            int[] input = [3, 0, 1];
            var output = Problem0268.MissingNumber(input);
            Assert.That(output, Is.EqualTo(2));
        }

        [Test]
        public void Test2()
        {
            int[] input = [0, 1];
            var output = Problem0268.MissingNumber(input);
            Assert.That(output, Is.EqualTo(2));
        }

        [Test]
        public void Test3()
        {
            int[] input = [9, 6, 4, 2, 3, 5, 7, 0, 1];
            var output = Problem0268.MissingNumber(input);
            Assert.That(output, Is.EqualTo(8));
        }
    }
}
