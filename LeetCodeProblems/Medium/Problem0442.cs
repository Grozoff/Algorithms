namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/find-all-duplicates-in-an-array/">Find All Duplicates in an Array</see>
    /// <br>Array, Hash Table</br>
    /// </summary>
    internal class Problem0442
    {
        public static IList<int> FindDuplicates(int[] nums)
        {
            var result = new List<int>();
            var t = new bool[nums.Length];
            foreach (var num in nums)
            {
                if (t[num - 1])
                {
                    result.Add(num);
                }
                else
                {
                    t[num - 1] = true;
                }
            }

            return result;

            // not my solution
            var duplicates = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] < 0)
                {
                    duplicates.Add(index + 1);
                }
                else
                {
                    nums[index] = -nums[index];
                }
            }
            return duplicates;
        }
    }

    public class Tests0442
    {
        [Test]
        public void Test1()
        {
            int[] s = [4, 3, 2, 7, 8, 2, 3, 1];
            var output = Problem0442.FindDuplicates(s);
        }

        [Test]
        public void Test2()
        {
            int[] s = [1];
            var output = Problem0442.FindDuplicates(s);
        }
    }
}
