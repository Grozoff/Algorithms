using System.Text;

namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/remove-k-digits">Remove K Digits</see>
    /// <br>String, Stack, Greedy, Monotonic Stack</br>
    /// </summary>
    internal class Problem0402
    {
        public string RemoveKdigits(string num, int k)
        {
            if (k == num.Length)
                return "0";

            var sb = new StringBuilder();

            foreach (var c in num)
            {
                while (k > 0 && sb.Length > 0 && sb[^1] > c)
                {
                    sb.Length--;
                    k--;
                }
                sb.Append(c);
            }

            sb.Length -= k;
            var result = sb.ToString().TrimStart('0');
            return result.Length == 0 ? "0" : result;
        }
    }
}
