namespace LeetCodeProblems.Hard
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/cherry-pickup-ii">Cherry Pickup II</see>
    /// <br>String, Dynamic Programming, Matrix</br>
    /// </summary>
    internal class Problem1463
    {
        public int CherryPickup(int[][] grid)
        {
            // not my solution (still hate dp)
            int row = grid.Length;
            int col = grid[0].Length;
            int[] possible_paths = new int[3] { -1, 0, 1 };

            var dp = new int[col][];
            for (int i = 0; i < col; i++)
            {
                dp[i] = new int[col];
            }

            for (int r = row - 1; r >= 0; r--)
            {

                int[][] curr_dp = new int[col][];
                for (int i = 0; i < col; i++)
                {
                    curr_dp[i] = new int[col];
                }

                for (int c1 = 0; c1 < col - 1; c1++)
                {
                    for (int c2 = c1 + 1; c2 < col; c2++)
                    {
                        int max_cherries = 0;
                        int curr_cherries = grid[r][c1] + grid[r][c2];
                        foreach (var c1_delta in possible_paths)
                        {
                            foreach (var c2_delta in possible_paths)
                            {
                                int newC1 = c1 + c1_delta;
                                int newC2 = c2 + c2_delta;
                                if (newC1 < 0 || newC2 >= col)
                                {
                                    continue;
                                }
                                max_cherries = Math.Max(max_cherries, curr_cherries + dp[newC1][newC2]);
                                curr_dp[c1][c2] = max_cherries;
                            }
                        }
                    }
                }
                dp = curr_dp;
            }
            return dp[0][col - 1];
        }
    }
}
