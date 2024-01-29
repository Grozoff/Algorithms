namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/min-stack">Min Stack</see>
    /// <br>Stack, Design</br>
    /// </summary>
    public class MinStack
    {
        private Stack<int> _stack = new Stack<int>();

        public MinStack()
        {
        }

        public void Push(int val)
        {
            _stack.Push(val);
        }

        public void Pop()
        {
            _stack.Pop();
        }

        public int Top()
        {
            return _stack.Peek();
        }

        public int GetMin()
        {
            return _stack.Min();
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(val);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */

    internal class Problem0155
    {
    }
}
