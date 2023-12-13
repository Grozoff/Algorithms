namespace Algorithms.LeetCode.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/">Number of Steps to Reduce a Number to Zero</see>
    /// <br>Math, Bit Manipulation</br>
    /// </summary>
    internal class Problem1342
    {
        public int NumberOfSteps(int num)
        {
            var result = 0;

            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                    result++;
                }
                else
                {
                    num--;
                    result++;
                }
            }

            return result;
        }
    }
}
