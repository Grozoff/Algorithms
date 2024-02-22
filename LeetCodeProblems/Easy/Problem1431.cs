namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/kids-with-the-greatest-number-of-candies'>Kids With the Greatest Number of Candies</see>
    /// <br>Array</br>
    /// </summary>
    internal class Problem1431
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var result = new bool[candies.Length];
            var max = candies.Max();
            for (int i = 0; i < candies.Length; i++)
            {
                result[i] = max <= candies[i] + extraCandies;
            }

            return result;

            return candies.Select(x => x + extraCandies >= candies.Max()).ToArray();
        }
    }
}
