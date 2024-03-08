namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/count-elements-with-maximum-frequency">Count Elements With Maximum Frequency</see>
    /// <br>Array, Hash Table, Counting</br>
    /// </summary>
    internal class Problem3005
    {
        public int MaxFrequencyElements(int[] nums)
        {
            var dict = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (dict.TryGetValue(num, out var val))
                {
                    dict[num]++;
                }
                else
                {
                    dict.Add(num, 1);
                }
            }
            var m = dict.MaxBy(x => x.Value).Value;
            return dict.Where(x => x.Value == m).Sum(x => x.Value);

            // not my solution
            Dictionary<int, int> d = new();
            int maxFrequency = 0;

            foreach (var n in nums)
            {
                int count = 1;

                if (!d.TryAdd(n, count))
                {
                    count = d[n] + 1;
                    d[n] = count;
                }

                maxFrequency = maxFrequency < count ? count : maxFrequency;
            }

            return d.Values.Count(c => c == maxFrequency) * maxFrequency;
        }
    }
}
