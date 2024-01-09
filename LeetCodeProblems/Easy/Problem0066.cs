namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/plus-one/">Plus One</see>
    /// <br>Array, Math</br>
    /// </summary>
    internal class Problem0066
    {
        public int[] PlusOne(int[] digits)
        {
            if (digits[^1] < 9)
            {
                digits[^1] += 1;
                return digits;
            }
            else if (digits.All(x => x == 9))
            {
                var result = new int[digits.Length + 1];
                result[0] = 1;
                return result;
            }
            else
            {
                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    if (digits[i] == 9)
                    {
                        digits[i] = 0;
                        continue;
                    }

                    digits[i] += 1;
                    break;
                }
                return digits;
            }
        }
    }
}
