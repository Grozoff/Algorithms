namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/decode-string">Decode String</see>
    /// <br>String, Stack, Recursion</br>
    /// </summary>
    internal class Problem0394
    {
        public string DecodeString(string s)
        {
            var stack = new Stack<string>();
            var resultStr = "";
            foreach (char c in s)
            {
                if (c != ']')
                {
                    stack.Push(c.ToString());
                }
                else
                {
                    var str = "";
                    var stackVal = stack.Pop();
                    while (stackVal != "[")
                    {
                        str = stackVal + str;
                        stackVal = stack.Pop();
                    }
                    var digitStr = "";
                    while (stack.Count > 0 && char.IsDigit(stack.Peek()[0]))
                    {
                        digitStr = stack.Pop() + digitStr;
                    }
                    if (int.TryParse(digitStr, out var multiplier))
                    {
                        str = String.Concat(Enumerable.Repeat(str, multiplier));
                        stack.Push(str);
                    }
                }
            }
            while (stack.Count > 0)
            {
                resultStr = stack.Pop() + resultStr;
            }
            return resultStr;
        }
    }
}
