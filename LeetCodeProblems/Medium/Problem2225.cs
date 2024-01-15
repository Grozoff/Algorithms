namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/find-players-with-zero-or-one-losses'>Find Players With Zero or One Losses</see>
    /// <br>Array, Hash Table, Sorting, Counting</br>
    /// </summary>
    internal class Problem2225
    {
        public static IList<IList<int>> FindWinners(int[][] matches)
        {
            var dict = new Dictionary<int, int>();

            foreach (var m in matches)
            {
                dict.TryAdd(m[0], 0);
                if (dict.TryGetValue(m[1], out int value))
                    dict[m[1]] = ++value;
                else
                    dict.Add(m[1], 1);
            }

            var l0 = new SortedList<int, int>();
            var l1 = new SortedList<int, int>();

            foreach (var kv in dict)
                if (kv.Value == 0)
                    l0.Add(kv.Key, 0);
                else if (kv.Value == 1)
                    l1.Add(kv.Key, 0);

            return new List<IList<int>> { l0.Keys, l1.Keys };

            // with linq
            HashSet<int> winners = new(matches.Select(x => x[0]));
            List<int> losers = new(matches.Select(x => x[1]));

            return new List<IList<int>>
                    {
                        winners.Except(losers).OrderBy(x => x).ToList(),
                        losers.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key).OrderBy(x => x).ToList()
                    };
        }
    }

    public class Tests2225
    {
        [Test]
        public void Test1()
        {
            var s = new int[][] { [1, 3], [2, 3], [3, 6], [5, 6], [5, 7], [4, 5], [4, 8], [4, 9], [10, 4], [10, 9] };
            var output = Problem2225.FindWinners(s);
        }
    }
}
