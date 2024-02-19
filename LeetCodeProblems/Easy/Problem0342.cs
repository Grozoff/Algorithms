using System.Numerics;

namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/power-of-four/'>Power of Four</see>
    /// <br>Math, Bit Manipulation, Recursion</br>
    /// </summary>
    internal class Problem0342
    {
        public bool IsPowerOfFour(int n)
        {
            if (n == 0)
                return false;

            while (n != 1)
            {
                if (n % 4 != 0)
                    return false;
                n /= 4;
            }

            return true;

            // not my solutions
            if (n > 0)
            {
                var units = BitOperations.PopCount((uint)n);
                var zeros = BitOperations.TrailingZeroCount((uint)n);
                return units == 1 && zeros % 2 == 0;
            }
            return false;


            if (n < 1) return false;

            double nLog = (Math.Log(n) / Math.Log(4));

            return nLog - (int)nLog == 0;

            var log = Math.Log(n, 4);
            return log == (int)log;
        }
    }
}
