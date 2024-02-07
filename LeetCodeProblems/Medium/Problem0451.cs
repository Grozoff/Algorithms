namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/sort-characters-by-frequency">Sort Characters By Frequency</see>
    /// <br>Hash Table, String, Sorting, Heap(Priority Queue), Bucket Sort, Counting</br>
    /// </summary>
    internal class Problem0451
    {
        public string FrequencySort(string s)
        {
            var d = new Dictionary<char, IList<char>>();

            foreach (var c in s)
            {
                if (d.TryGetValue(c, out var val))
                {
                    d[c].Add(c);
                }
                else
                {
                    d.Add(c, new List<char> { c });
                }
            }


            return new string(d.Values.OrderByDescending(x => x.Count).SelectMany(x => x).ToArray());

            // one line solution
            return new string(s.GroupBy(x => x).OrderByDescending(x => x.Count()).SelectMany(x => x).ToArray());
        }
    }
}
