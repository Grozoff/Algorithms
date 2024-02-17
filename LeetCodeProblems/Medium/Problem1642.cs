namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/furthest-building-you-can-reach'>Furthest Building You Can Reach</see>
    /// <br>Array, Greedy, Heap(Priority Queue)</br>
    /// </summary>
    internal class Problem1642
    {
        public int FurthestBuilding(int[] heights, int bricks, int ladders)
        {
            var q = new PriorityQueue<int, int>();

            for (int i = 0; i < heights.Length - 1; i++)
            {
                var diff = heights[i + 1] - heights[i];
                if (diff <=0)
                    continue;

                bricks -= diff;
                q.Enqueue(-diff, -diff);

                if (bricks < 0)
                {
                    if (ladders == 0)
                        return i;

                    ladders--;
                    bricks += -q.Dequeue();
                }
            }

            return heights.Length - 1;
        }
    }
}
