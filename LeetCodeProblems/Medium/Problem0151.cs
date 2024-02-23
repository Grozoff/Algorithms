using System.Text;

namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/reverse-words-in-a-string'>Reverse Words in a String</see>
    /// <br>Two Pointers, String</br>
    /// </summary>
    internal class Problem0151
    {
        public string ReverseWords(string s)
        {
            var words = s.Trim().Split(' ');
            var sb = new StringBuilder();
            for (int i = words.Length - 1; i > 0; i--)
            {
                if (string.IsNullOrEmpty(words[i])) continue;
                sb.Append(words[i]);
                sb.Append(" ");
            }
            sb.Append(words.First());
            return sb.ToString();

            // LINQ
            return string.Join(' ', s.Split(' ').Where(x => x.Length > 0).Reverse());
        }
    }
}
