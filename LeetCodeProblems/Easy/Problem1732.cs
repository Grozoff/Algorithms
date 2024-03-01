namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/find-the-highest-altitude'>Find the Highest Altitude</see>
    /// <br>Array, Prefix Sum</br>
    /// </summary>
    internal class Problem1732
    {
        public int LargestAltitude(int[] gain)
        {
            var max = 0;
            var prevAlt = 0;
            foreach (var g in gain)
            {
                prevAlt += g;
                max = Math.Max(prevAlt, max);
            }
            return max;
        }
    }
}
