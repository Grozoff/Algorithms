namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/greatest-common-divisor-of-strings'>Greatest Common Divisor of Strings</see>
    /// <br>Math, String</br>
    /// </summary>
    internal class Problem1071
    {
        public string GcdOfStrings(string str1, string str2)
        {
            if (str1.Equals(str2))
            {
                return str1;
            }
            if (str2.Length > str1.Length)
            {
                return GcdOfStrings(str2, str1);
            }
            if (str1.StartsWith(str2))
            {
                return GcdOfStrings(str1[str2.Length..], str2);
            }
            return "";

            if (str1 + str2 != str2 + str1)
                return string.Empty;

            return str1[..Gcd(str1.Length, str2.Length)];
        }

        public static int Gcd(int x, int y)
        {
            if (y == 0)
            {
                return x;
            }
            else
            {
                return Gcd(y, x % y);
            }
        }
    }
}
