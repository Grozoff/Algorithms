namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/group-anagrams">Group Anagrams</see>
    /// <br>Array, Hash Table, String, Sorting</br>
    /// </summary>
    internal class Problem0049
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var d = new Dictionary<string, IList<string>>();

            foreach (var item in strs)
            {
                var t = item.ToArray();
                Array.Sort(t);
                var ts = new string(t);
                if (d.TryGetValue(ts, out IList<string>? value))
                {
                    value.Add(item);
                }
                else
                {
                    d.Add(ts, new List<string>
                    {
                        item
                    });
                }
            }

            return d.Values.ToList();

            // linq only
            return strs
                    .GroupBy(s => new string(s.OrderBy(c => c).ToArray()))
                    .Select(g => g.ToList() as IList<string>)
                    .ToList();
        }
    }

    public class Tests49
    {

        [Test]
        public void Test1()
        {
            var input = new string[]
            {
                "eat","tea","tan","ate","nat","bat"
            };

            var asd = Problem0049.GroupAnagrams(input);
        }
    }
}
