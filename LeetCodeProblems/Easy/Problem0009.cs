namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/palindrome-number'>Palindrome Number</see>
    /// <br>Math</br>
    /// </summary>
    internal class Problem0009
    {
        public bool IsPalindrome(int x)
        {
            var s = x.ToString();
            
            return s.SequenceEqual(s.Reverse());
        }
    }
}
