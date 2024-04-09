namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/time-needed-to-buy-tickets/">Time Needed to Buy Tickets</see>
    /// <br>Array, Queue, Simulation</br>
    /// </summary>
    internal class Problem2073
    {
        public int TimeRequiredToBuy(int[] tickets, int k)
        {
            var result = 0;
            for (int i = 0; i < tickets.Length; i++)
            {
                if (i <= k)
                {
                    if (tickets[i] <= tickets[k])
                        result += tickets[i];
                    else
                        result += tickets[k];
                }
                else
                {
                    if (tickets[i] >= tickets[k])
                        result += tickets[k] - 1;
                    else
                    {
                        result += tickets[i];
                    }
                }
            }

            return result;
        }
    }
}
