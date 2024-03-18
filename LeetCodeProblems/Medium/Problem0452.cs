namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/minimum-number-of-arrows-to-burst-balloons/'>Minimum Number of Arrows to Burst Balloons</see>
    /// <br>Array, Greedy, Sorting</br>
    /// </summary>
    internal class Problem0452
    {
        public int FindMinArrowShots(int[][] points)
        {
            Array.Sort(points, (a, b) => a[1].CompareTo(b[1]));

            var result = points.Length;
            var prev = points[0];

            for (int i = 1; i < points.Length; i++)
            {
                var current = points[i];
                if (current[0] <= prev[1])
                {
                    result--;
                    prev = [current[0], Math.Min(current[1], prev[1])];
                }
                else
                {
                    prev = current;
                }
            }

            return result;
        }
    }
}
