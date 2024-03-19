namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/number-of-provinces'>Number of Provinces</see>
    /// <br>Depth-First Search, Breadth-First Search, Union Find, Graph</br>
    /// </summary>
    internal class Problem0547
    {
        public static int FindCircleNum(int[][] isConnected)
        {
            var visit = new bool[isConnected.Length];
            var result = 0;

            for (int i = 0; i < isConnected.Length; i++)
            {
                if (!visit[i])
                {
                    result++;
                    Dfs(i, isConnected, visit);
                }
            }

            return result;
        }

        private static void Dfs(int node, int[][] isConnected, bool[] visit)
        {
            visit[node] = true;
            for (int i = 0; i < isConnected.Length; i++)
            {
                if (isConnected[node][i] == 1 && !visit[i])
                {
                    Dfs(i, isConnected, visit);
                }
            }
        }
    }

    public class Tests0547
    {
        [Test]
        public void Test1()
        {
            int[][] s = [[1, 1, 0], [1, 1, 0], [0, 0, 1]];
            var output = Problem0547.FindCircleNum(s);
        }

        [Test]
        public void Test2()
        {
            int[][] s = [[1, 0, 0], [0, 1, 0], [0, 0, 1]];
            var output = Problem0547.FindCircleNum(s);
        }
    }
}
