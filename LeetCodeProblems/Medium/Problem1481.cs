namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/least-number-of-unique-integers-after-k-removals'>Least Number of Unique Integers after K Removals</see>
    /// <br>Array, Hash Table, Greedy, Sorting, Counting</br>
    /// </summary>
    internal class Problem1481
    {
        public static int FindLeastNumOfUniqueInts(int[] arr, int k)
        {
            var dict = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (dict.TryGetValue(num, out int value))
                    dict[num] = ++value;
                else dict[num] = 1;
            }

            var kvs = dict.OrderBy(x => x.Value);

            var t = k;

            var lst = new List<int>();

            foreach (var kv in dict.OrderBy(x => x.Value))
            {
                for (var i = 0; i < kv.Value; i++)
                {
                    lst.Add(kv.Key);
                }
            }
            return lst.Skip(k).Distinct().Count();

            // one line solution
            return arr.GroupBy(x => x).OrderBy(x => x.Count()).SelectMany(x => x).Skip(k).Distinct().Count();
        }
    }

    public class Tests1481
    {
        [Test]
        public void Test1()
        {
            var input = new int[] { 4, 3, 1, 1, 3, 3, 2 };
            var output = Problem1481.FindLeastNumOfUniqueInts(input, 3);

            Assert.That(output, Is.EqualTo(2));
        }

        [Test]
        public void Test2()
        {
            var input = new int[] { 24, 119, 157, 446, 251, 117, 22, 168, 374, 373, 323, 311, 441, 213, 120, 412, 200, 236, 328, 24, 164, 104, 331, 32, 19, 223, 89, 114, 152, 82, 456, 381, 355, 343, 157, 245, 443, 368, 229, 49, 82, 16, 373, 142, 240, 125, 8 };
            var output = Problem1481.FindLeastNumOfUniqueInts(input, 41);

            Assert.That(output, Is.EqualTo(3));
        }
    }
}
