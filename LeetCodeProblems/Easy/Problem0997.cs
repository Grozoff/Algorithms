namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/find-the-town-judge'>Find the Town Judge</see>
    /// <br>Array, Hash Table, Graph</br>
    /// </summary>
    internal class Problem0997
    {
        public int FindJudge(int n, int[][] trust)
        {
            int[] indegree = new int[n + 1];
            int[] outdegree = new int[n + 1];
            int judge = -1;
            foreach (int[] person in trust)
            {
                indegree[person[1]]++;
                outdegree[person[0]]++;
            }

            for (int i = 1; i <= n; i++)
                if (indegree[i] == n - 1 && outdegree[i] == 0 && judge == -1)
                    judge = i;

            return judge;
        }
    }
}
