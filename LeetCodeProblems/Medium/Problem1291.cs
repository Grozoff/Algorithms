namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/sequential-digits/'>Sequential Digits</see>
    /// <br>Enumeration</br>
    /// </summary>
    internal class Problem1291
    {
        public IList<int> SequentialDigits(int low, int high)
        {
            int[] allSequentialNumbers = [12, 23, 34, 45, 56, 67, 78, 89, 123, 234, 345, 456, 567, 678, 789, 1234, 2345, 3456, 4567, 5678, 6789, 12345, 23456, 34567, 45678, 56789, 123456, 234567, 345678, 456789, 1234567, 2345678, 3456789, 12345678, 23456789, 123456789];

            return allSequentialNumbers.Where(x => x >= low && high >= x).ToList();

            // not my solution
            var result = new List<int>();

            for (int digit = 1; digit < 9; digit++)
            {
                int num = digit;
                int nextDigit = num + 1;

                while (num <= high && nextDigit <= 9)
                {
                    num = (num * 10) + nextDigit;
                    if (num >= low && num <= high) result.Add(num);

                    nextDigit++;
                }
            }

            result.Sort();
            return result;
        }
    }
}
