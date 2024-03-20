namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/top-k-frequent-elements">Top K Frequent Elements</see>
    /// <br>Array, Hash Table, Sorting, Heap(Priority Queue), Bucket Sort, Counting, Quickselect</br>
    /// </summary>
    internal class Problem0347
    {
        public int[] TopKFrequent(int[] nums, int k)
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
                    dict[num] = 1;
                }
            }

            return dict.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();

            // one line solution
            return nums.GroupBy(x => x).OrderByDescending(x => x.Count()).Select(x => x.Key).Take(k).ToArray();
        }
    }
}
