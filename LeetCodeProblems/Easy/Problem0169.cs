namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/majority-element">Majority Element</see>
    /// <br>Array, Hash Table, Divide and Conquer, Sorting, Counting</br>
    /// </summary>
    internal class Problem0169
    {
        public static int MajorityElement(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (dict.TryGetValue(num, out var val))
                {
                    dict[num] = ++val;
                }
                else
                {
                    dict.Add(num, 1);
                }
            }
            return dict.OrderBy(x => x.Value).Last().Key;

            // cheating??
            Array.Sort(nums);
            return nums[nums.Length / 2];
        }
    }

    public class Tests0169
    {
        [Test]
        public void Test1()
        {
            var input = new[] { 6,5,5 };
            var output = Problem0169.MajorityElement(input);

            Assert.That(5, Is.EqualTo(output));
        }
    }
}
