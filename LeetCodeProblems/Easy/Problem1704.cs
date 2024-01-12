namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/determine-if-string-halves-are-alike">Determine if String Halves Are Alike</see>
    /// <br>String, Counting</br>
    /// </summary>
    internal class Problem1704
    {
        public bool HalvesAreAlike(string s)
        {
            var vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            return s[..((s.Length + 1) / 2)].Count(c => vowels.Contains(c)) ==
            s[((s.Length + 1) / 2)..].Count(c => vowels.Contains(c));
        }
    }
}
