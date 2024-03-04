namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/bag-of-tokens">Bag of Tokens</see>
    /// <br>Array, Two Pointers, Greedy, Sorting</br>
    /// </summary>
    internal class Problem0948
    {
        public int BagOfTokensScore(int[] tokens, int power)
        {
            Array.Sort(tokens);
            var result = 0;
            var score = 0;
            var left = 0;
            var right = tokens.Length - 1;

            while (left <= right)
            {
                if (power >= tokens[left])
                {
                    power -= tokens[left];
                    left++;
                    score++;
                    result = Math.Max(result, score);
                }
                else if (score > 0)
                {
                    power += tokens[right];
                    right--;
                    score--;
                }
                else
                {
                    break;
                }
            }

            return result;
        }
    }
}
