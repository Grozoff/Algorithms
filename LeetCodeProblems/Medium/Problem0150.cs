namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/evaluate-reverse-polish-notation/">Evaluate Reverse Polish Notation</see>
    /// <br>Array, Math, Stack</br>
    /// </summary>
    internal class Problem0150
    {
        public int EvalRPN(string[] tokens)
        {
            var stack = new Stack<int>();

            foreach (var token in tokens)
            {
                if (token is "-" or "+" or "*" or "/")
                {
                    var right = stack.Pop();
                    var left = stack.Pop();
                    var result = token switch
                    {
                        "+" => left + right,
                        "-" => left - right,
                        "*" => left * right,
                        "/" => left / right,
                    };
                    stack.Push(result);
                }
                else
                {
                    stack.Push(int.Parse(token));
                }
            }

            return stack.Pop();
        }
    }
}
