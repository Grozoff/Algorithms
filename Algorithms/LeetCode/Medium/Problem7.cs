namespace Algorithms.LeetCode.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/reverse-integer/">Reverse Integer</see>
    /// <br>Math</br>
    /// </summary>
    internal class Problem7
    {
        public static int Reverse(int s)
        {
            if (-9 <= s && s <= 9)
            {
                return s;
            }

            var isItn32 = int.TryParse(new string(s.ToString().Trim('-').Reverse().ToArray()), out int intValue);
            return isItn32 ? s.ToString().Contains('-') ? intValue * -1 : intValue : 0;
        }
    }
}
