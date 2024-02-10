namespace LeetCodeProblems.Medium
{
    internal class Problem0647
    {
        public int CountSubstrings(string s)
        {
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                result += CountSubstrings(s, i, i);
                result += CountSubstrings(s, i, i + 1);
            }

            return result;
        }

        private int CountSubstrings(string s, int left, int right)
        {
            var result = 0;

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                result++;
                left--;
                right++;
            }

            return result;
        }
    }
}
