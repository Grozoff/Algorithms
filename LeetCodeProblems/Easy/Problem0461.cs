namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/hamming-distance/">Hamming Distance</see>
    /// <br>Bit Manipulation</br>
    /// </summary>
    internal class Problem0461
    {
        public int HammingDistance(int x, int y)
        {
            return Convert.ToString(x ^ y, 2).Count(x => x == '1');
        }
    }
}
