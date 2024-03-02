namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/equal-row-and-column-pairs'>Equal Row and Column Pairs</see>
    /// <br>Array, Hash Table, Matrix, Simulation</br>
    /// </summary>
    internal class Problem2352
    {
        public static int EqualPairs(int[][] grid)
        {
            var result = 0;

            Dictionary<string, int> row = [];

            for (int i = 0; i < grid.Length; i++)
            {
                string key = string.Join(",", grid[i]);

                if (!row.TryGetValue(key, out int value))
                {
                    row.Add(key, 1);
                }
                else
                {
                    row[key] = ++value;
                }
            }

            for (int i = 0; i < grid[0].Length; i++)
            {
                int[] column = new int[grid.Length];

                for (int j = 0; j < grid.Length; j++)
                {
                    column[j] = grid[j][i];
                }

                string columnKey = string.Join(",", column);

                if (row.TryGetValue(columnKey, out int value))
                {
                    result += value;
                }
            }

            return result;
        }
    }

    public class Tests2352
    {
        [Test]
        public void Test1()
        {
            var s = new int[][]
            {
                [3, 2, 1],
                [1, 7, 6],
                [2, 7, 7]
            };
            var output = Problem2352.EqualPairs(s);
        }

        [Test]
        public void Test2()
        {
            var s = new int[][]
            {
                [13,13],
                [13,13]
            };
            var output = Problem2352.EqualPairs(s);
        }
    }
}
