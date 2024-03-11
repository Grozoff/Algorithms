using System.Text;

namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/custom-sort-string/">Custom Sort String</see>
    /// <br>Hash Table, String, Sorting</br>
    /// </summary>
    internal class Problem0791
    {
        public string CustomSortString(string order, string s)
        {
            var sb = new StringBuilder();
            var dict = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (dict.TryGetValue(c, out var _))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }

            foreach (var c in order)
            {
                if (dict.TryGetValue(c, out var val))
                {
                    sb.Append(c, val);
                    dict.Remove(c);
                }
            }

            foreach (var d in dict)
            {
                sb.Append(d.Key, d.Value);
            }

            return sb.ToString();

            // one line
            return string.Concat(s.OrderBy(order.IndexOf));
        }
    }
}
