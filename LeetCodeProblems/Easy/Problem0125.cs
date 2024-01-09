using System.Text;

namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/valid-palindrome/">Valid Palindrome</see>
    /// <br>Two Pointers, String</br>
    /// </summary>
    internal class Problem0125
    {
        public bool IsPalindrome(string s)
        {
            var sb = new StringBuilder();
            if (s.Trim().Length == 0)
            {
                return true;
            }

            foreach (char c in s)
            {
                if (char.IsLetter(c) || char.IsDigit(c))
                    sb.Append(c);
            }
            var result = sb.ToString().ToLower();
            return string.Join("", result.Reverse()) == result;
        }
    }
}
