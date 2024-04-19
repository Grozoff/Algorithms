namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/number-of-islands">Number of Islands</see>
    /// <br>Array, Depth-First Search, Breadth-First Search, Union Find, Matrix</br>
    /// </summary>
    internal class Program0200
    {
        public int NumIslands(char[][] grid)
        {
            var islands = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        DFS(grid, i, j);
                        islands++;
                    }
                }
            }
            return islands;
        }

        private void DFS(char[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == '0')
            {
                return;
            }
            grid[i][j] = '0';

            DFS(grid, i - 1, j);
            DFS(grid, i + 1, j);
            DFS(grid, i, j - 1);
            DFS(grid, i, j + 1);
        }
    }
}
