using System.Text;

namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/merge-strings-alternately'>Merge Strings Alternately</see>
    /// <br>Two Pointers, String</br>
    /// </summary>
    internal class Problem1768
    {
        public string MergeAlternately(string word1, string word2)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < word1.Length || i < word2.Length; i++)
            {
                if (i < word1.Length)
                {
                    sb.Append(word1[i]);
                }

                if (i < word2.Length)
                {
                    sb.Append(word2[i]);
                }
            }

            return sb.ToString();
        }
    }
}
