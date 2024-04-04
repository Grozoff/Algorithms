namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/maximum-nesting-depth-of-the-parentheses/">Maximum Nesting Depth of the Parentheses</see>
    /// <br>String, Stack</br>
    /// </summary>
    internal class Problem1614
    {
        public int MaxDepth(string s)
        {
            var result = 0;
            var max = 0;
            foreach (var ch in s)
            {
                if (ch == '(')
                {
                    max++;
                }
                if (ch == ')')
                {
                    result = Math.Max(result, max);
                    max--;
                }
            }
            return result;
        }
    }
}
