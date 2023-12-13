using System.Text;

namespace Algorithms.LeetCode.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/longest-common-prefix/">Longest Common Prefix</see>
    /// <br>String, Trie</br>
    /// </summary>
    internal class Problem14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var firstWord = strs.OrderBy(x => x.Length).First();
            var sb = new StringBuilder();
            for (int i = 0; i < firstWord.Length; i++)
            {
                if (strs.All(x => x[i] == firstWord[i]))
                {
                    sb.Append(firstWord[i]);
                    continue;
                }
                break;
            }

            return sb.ToString();
        }
    }
}
