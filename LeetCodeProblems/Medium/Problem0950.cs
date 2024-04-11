namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/reveal-cards-in-increasing-order">Reveal Cards In Increasing Order</see>
    /// <br>Array, Queue, Sorting, Simulation</br>
    /// </summary>
    internal class Problem0950
    {
        public int[] DeckRevealedIncreasing(int[] deck)
        {
            Array.Sort(deck);
            var ans = new int[deck.Length];
            var q = new Queue<int>(Enumerable.Range(0, deck.Length));

            for (var i = 0; i < deck.Length; i++)
            {
                ans[q.Dequeue()] = deck[i];
                if (q.Count > 0)
                {
                    q.Enqueue(q.Dequeue());
                }
            }

            return ans;
        }
    }
}
