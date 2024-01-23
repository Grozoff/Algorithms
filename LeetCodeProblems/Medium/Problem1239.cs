namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/maximum-length-of-a-concatenated-string-with-unique-characters'>Maximum Length of a Concatenated String with Unique Characters</see>
    /// <br>Array, String, Backtracking, Bit Manipulation</br>
    /// </summary>
    internal class Problem1239
    {
        public int MaxLength(IList<string> arr)
        {
            return MaxLength(arr, 0, "");
        }
        private int MaxLength(IList<string> arr, int i = 0, string s = "")
        {
            if (s.Distinct().Count() < s.Length) return 0;

            if (arr.Count == i) return s.Length;

            return Math.Max(
                MaxLength(arr, i + 1, s),
                MaxLength(arr, i + 1, s + arr[i])
            );
        }
    }
}
