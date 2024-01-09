namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/reverse-string/">Reverse String</see>
    /// <br>String, Two Pointers</br>
    /// </summary>
    internal class Problem0344
    {
        public void ReverseString(char[] s)
        {
            var a = s.ToArray();

            var counter = s.Length - 1;
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = a[counter];
                counter--;
            }
        }
    }
}
