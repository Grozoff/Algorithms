namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/removing-stars-from-a-string">Removing Stars From a String</see>
    /// <br>String, Stack, Simulation</br>
    /// </summary>
    internal class Problem2390
    {
        public string RemoveStars(string s)
        {
            var stack = new Stack<char>();
            foreach (var ch in s)
            {
                if (ch == '*')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(ch);
                }
            }
            return new string(stack.Reverse().ToArray());
        }
    }
}
