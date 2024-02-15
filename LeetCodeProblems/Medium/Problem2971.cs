namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/find-polygon-with-the-largest-perimeter/'>Find Polygon With the Largest Perimeter</see>
    /// <br>Array, Greedy, Sorting, Prefix Sum</br>
    /// </summary>
    internal class Problem2971
    {
        public long LargestPerimeter(int[] nums)
        {
            Array.Sort(nums);
            long result = -1;
            long total = 0;
            foreach (var num in nums)
            {
                if (total > num)
                {
                    result = total + num;
                }
                total += num;
            }

            return result;
        }
    }
}
