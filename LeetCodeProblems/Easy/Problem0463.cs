namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/island-perimeter">Island Perimeter</see>
    /// <br>Array, Depth-First Search, Breadth-First Search, Matrix</br>
    /// </summary>
    internal class Problem0463
    {
        public int IslandPerimeter(int[][] grid)
        {
            int res = 0;
            int n = grid.Length;
            int m = grid[0].Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        if (i == 0 || grid[i - 1][j] == 0) res++;
                        if (i == n - 1 || grid[i + 1][j] == 0) res++;
                        if (j == 0 || grid[i][j - 1] == 0) res++;
                        if (j == m - 1 || grid[i][j + 1] == 0) res++;
                    }
                }
            }

            return res;
        }
    }
}
