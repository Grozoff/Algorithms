namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/cheapest-flights-within-k-stops'>Cheapest Flights Within K Stops</see>
    /// <br>Dynamic Programming, Depth-First Search, Breadth-First Search, Graph, Heap(Priority Queue), Shortest Path</br>
    /// </summary>
    internal class Problem0787
    {
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
        {
            // Create an array to store the minimum cost to reach each node.
            int[] dist = new int[n];
            // Initialize the array with maximum values, except for the source node which has cost 0.
            Array.Fill(dist, int.MaxValue);
            dist[src] = 0;
            // Iterate through each stop up to k.
            for (int i = 0; i <= k; i++)
            {
                // Create a temporary array to store the updated costs for this iteration.
                var temp = dist.ToArray();
                // Iterate through each flight.
                foreach (int[] flight in flights)
                {
                    // Check if we can reach the starting node of the current flight from the source node.
                    if (dist[flight[0]] != int.MaxValue)
                    {
                        // Update the cost to reach the destination node of the current flight if it's cheaper.
                        temp[flight[1]] = Math.Min(temp[flight[1]], dist[flight[0]] + flight[2]);
                    }
                }
                // Update dp array with the temporary array for this iteration.
                dist = temp;
            }
            // Return the cost to reach the destination node. If it's still Integer.MAX_VALUE, it means it's not reachable.
            return dist[dst] == int.MaxValue ? -1 : dist[dst];
        }
    }
}
