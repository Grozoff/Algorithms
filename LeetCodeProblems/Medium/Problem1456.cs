namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length'>Maximum Number of Vowels in a Substring of Given Length</see>
    /// <br>String, Sliding Window</br>
    /// </summary>
    internal class Problem1456
    {
        public static int MaxVowels(string s, int k)
        {
            char[] vowels = ['a', 'e', 'i', 'o', 'u'];
            var result = 0;
            for (int i = 0; i < k; i++)
            {
                if (vowels.Contains(s[i]))
                    result++;
            }
            var maxResult = result;

            for (int i = k; i < s.Length; i++)
            {
                if (vowels.Contains(s[i - k]))
                    result--;
                if (vowels.Contains(s[i]))
                    result++;
                maxResult = Math.Max(result, maxResult);
            }
            return maxResult;
        }
    }

    public class Tests1456
    {
        [Test]
        public void Test1()
        {
            var s = "abciiidef";
            var output = Problem1456.MaxVowels(s, 3);

            Assert.That(output, Is.EqualTo(3));
        }

        [Test]
        public void Test2()
        {
            var s = "aeiou";
            var output = Problem1456.MaxVowels(s, 2);

            Assert.That(output, Is.EqualTo(2));
        }

        [Test]
        public void Test3()
        {
            var s = "leetcode";
            var output = Problem1456.MaxVowels(s, 3);

            Assert.That(output, Is.EqualTo(2));
        }
    }
}
