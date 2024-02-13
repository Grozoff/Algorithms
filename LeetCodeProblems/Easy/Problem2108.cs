namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/find-first-palindromic-string-in-the-array">Find First Palindromic String in the Array</see>
    /// <br>Array, Two Pointers, String</br>
    /// </summary>
    internal class Problem2108
    {
        public static string FirstPalindrome(string[] words)
        {
            foreach (var word in words)
            {
                var isPalindrome = IsPalindrome(word);
                if (isPalindrome)
                    return word;

            }

            return string.Empty;
        }

        private static bool IsPalindrome(string word)
        {
            for (var i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[^(i+1)])
                    return false;
            }
            return true;
        }
    }

    public class Tests2108
    {
        [Test]
        public void Test1()
        {
            var input = new[] { "abc", "car", "ada", "racecar", "cool" };
            var output = Problem2108.FirstPalindrome(input);

            Assert.That("ada", Is.EqualTo(output));
        }
    }
}
