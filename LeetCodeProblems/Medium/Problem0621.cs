namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/task-scheduler/'>Task Scheduler</see>
    /// <br>Array, Hash Table, Greedy, Sorting, Heap(Priority Queue), Counting</br>
    /// </summary>
    internal class Problem0621
    {
        public int LeastInterval(char[] tasks, int n)
        {
            var freq = new int[26];
            foreach (var t in tasks)
            {
                freq[t - 'A']++;
            }

            Array.Sort(freq);

            var max = freq[^1];

            var time = (max - 1) * (n + 1);
            foreach (var f in freq)
            {
                if (f == max)
                    time++;
            }

            return Math.Max(tasks.Length, time);
        }
    }
}
