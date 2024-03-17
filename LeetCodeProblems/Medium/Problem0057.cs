namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/insert-interval/'>Insert Interval</see>
    /// <br>Array</br>
    /// </summary>
    internal class Problem0057
    {
        public static int[][] Insert(int[][] intervals, int[] newInterval)
        {
            var result = new List<int[]>();

            for (int i = 0; i < intervals.Length; i++)
            {
                if (newInterval[1] < intervals[i][0])
                {
                    result.Add(newInterval);
                    return [.. result, .. intervals[i..]];
                }
                else if (newInterval[0] > intervals[i][1])
                {
                    result.Add(intervals[i]);
                }
                else
                {
                    newInterval = [Math.Min(newInterval[0], intervals[i][0]), Math.Max(newInterval[1], intervals[i][1])];
                }
            }
            result.Add(newInterval);
            return [.. result];
        }
    }

    public class Tests0057
    {
        [Test]
        public void Test1()
        {
            int[][] input = [[1, 3], [6, 9]];
            int[] newInterval = [2, 5];
            var output = Problem0057.Insert(input, newInterval);
        }

        [Test]
        public void Test2()
        {
            int[][] input = [[1, 2], [3, 5], [6, 7], [8, 10], [12, 16]];
            int[] newInterval = [4, 8];
            var output = Problem0057.Insert(input, newInterval);
        }
    }
}
