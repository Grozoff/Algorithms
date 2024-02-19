namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/power-of-two'>Power of Two</see>
    /// <br>Math, Bit Manipulation, Recursion</br>
    /// </summary>
    internal class Problem0231
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n == 0)
                return false;

            while (n != 1)
            {
                if (n % 2 != 0)
                    return false;
                n /= 2;
            }

            return true;

            // not my solution
            if (n <= 0)
            {
                return false;
            }

            return (n & (n - 1)) == 0;
        }
    }
}
