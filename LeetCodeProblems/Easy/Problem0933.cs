namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/number-of-recent-calls">Number of Recent Calls</see>
    /// <br>Design, Queue, Data Stream</br>
    /// </summary>
    internal class Problem0933
    {
    }

    public class RecentCounter
    {
        Queue<int> q = new();
        public RecentCounter()
        {

        }

        public int Ping(int t)
        {
            q.Enqueue(t);

            while (q.Peek() < t - 3000)
            {
                q.Dequeue();
            }

            return q.Count;
        }
    }
}
