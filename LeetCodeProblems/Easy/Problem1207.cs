namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/unique-number-of-occurrences">Unique Number of Occurrences</see>
    /// <br>Array, Hash Table</br>
    /// </summary>
    internal class Problem1207
    {
        public static bool UniqueOccurrences(int[] arr)
        {
            var dict = new Dictionary<int, int>();

            foreach (var item in arr)
            {
                if (dict.TryGetValue(item, out int value))
                {
                    dict[item] = ++value;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }

            var hs = new HashSet<int>();

            foreach (var item in dict)
            {
                if (!hs.Add(item.Value))
                {
                    return false;
                }
            }

            return true;
        }
    }

    public class Tests1207
    {
        [Test]
        public void Test1()
        {
            int[] input = [1, 2, 2, 1, 1, 3];
            var output = Problem1207.UniqueOccurrences(input);

            Assert.True(output);
        }

        [Test]
        public void Test2()
        {
            int[] input = [1, 2];
            var output = Problem1207.UniqueOccurrences(input);

            Assert.False(output);
        }
    }
}
