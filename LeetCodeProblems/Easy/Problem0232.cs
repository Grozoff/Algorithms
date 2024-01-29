namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/implement-queue-using-stacks/">Implement Queue using Stacks</see>
    /// <br>Stack, Design, Queue</br>
    /// </summary>
    public class MyQueue
    {
        private Stack<int> _queue = new Stack<int>();
        private Stack<int> _eueuq = new Stack<int>();

        public MyQueue()
        {
        }

        public void Push(int x)
        {
            _queue.Push(x);
        }

        public int Pop()
        {
            Swap(_queue, _eueuq);
            var result = _eueuq.Pop();
            Swap(_eueuq, _queue);
            return result;
        }

        public int Peek()
        {
            Swap(_queue, _eueuq);
            return _eueuq.Peek();
        }

        public bool Empty()
        {
            return _queue.Count == 0 && _eueuq.Count == 0;
        }

        private static void Swap(Stack<int> queue, Stack<int> eueuq)
        {
            eueuq.Clear();
            foreach (int x in queue)
            {
                eueuq.Push(x);
            }
        }
    }

    /**
     * Your MyQueue object will be instantiated and called as such:
     * MyQueue obj = new MyQueue();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Peek();
     * bool param_4 = obj.Empty();
     */

    public class Tests0232
    {
        [Test]
        public void Test1()
        {
            var asd = new MyQueue();
            asd.Push(1);
            asd.Push(2);
            asd.Push(3);
            asd.Push(4);
            var one = asd.Pop(); // should be one
            asd.Push(5);
            var two = asd.Pop();
            var three = asd.Pop();
            var four = asd.Pop();
            var five = asd.Pop();
        }
    }
    internal class Problem0232
    {
    }
}
