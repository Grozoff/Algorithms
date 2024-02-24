namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/is-subsequence">Is Subsequence</see>
    /// <br>Two Pointers, String, Dynamic Programming</br>
    /// </summary>
    internal class Problem0392
    {
        public bool IsSubsequence(string s, string t)
        {
            var sp = 0;
            var tp = 0;
            while (sp < s.Length && tp < t.Length)
            {
                if (s[sp] == t[tp])
                {
                    sp++;
                    tp++;
                }
                else
                {
                    tp++;
                }
            }

            return s.Length == sp;
        }
    }
}
