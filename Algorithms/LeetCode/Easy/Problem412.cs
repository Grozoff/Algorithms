namespace Algorithms.LeetCode.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/fizz-buzz/">Fizz Buzz</see>
    /// <br>Math, String, Simulation</br>
    /// </summary>
    internal class Problem412
    {
        public IList<string> FizzBuzz(int n)
        {
            var result = new string[n];
            for (int i = 1; i < n + 1; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result[i - 1] = "FizzBuzz";
                    continue;
                }
                if (i % 3 == 0)
                {
                    result[i - 1] = "Fizz";
                    continue;
                }
                if (i % 5 == 0)
                {
                    result[i - 1] = "Buzz";
                    continue;
                }
                result[i - 1] = i.ToString();
            }

            return result;
        }
    }
}
