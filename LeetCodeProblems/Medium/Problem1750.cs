namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/minimum-length-of-string-after-deleting-similar-ends'>Minimum Length of String After Deleting Similar Ends</see>
    /// <br>Two Pointers, String</br>
    /// </summary>
    internal class Problem1750
    {
        public static int MinimumLength(string s)
        {
            var p1 = 0;
            var p2 = s.Length - 1;
            while (p1 < p2 && s[p1] == s[p2])
            {
                var tmp = s[p1];
                while (p1 <= p2 && s[p1] == tmp)
                {
                    p1++;
                }
                while (p1 <= p2 && s[p2] == tmp)
                {
                    p2--;
                }
            }

            return p2 - p1 + 1;
        }
    }

    public class Tests1750
    {
        [Test]
        public void Test1()
        {
            var input = "aabccabba";
            var output = Problem1750.MinimumLength(input);
        }

        [Test]
        public void Test2()
        {
            var input = "cabaabac";
            var output = Problem1750.MinimumLength(input);
        }

        [Test]
        public void Test3()
        {
            var input = "ca";
            var output = Problem1750.MinimumLength(input);
        }

        [Test]
        public void Test4()
        {
            var input = "abbbbbbbbbbbbbbbbbbba";
            var output = Problem1750.MinimumLength(input);
        }

        [Test]
        public void Test5()
        {
            var input = "a";
            var output = Problem1750.MinimumLength(input);
        }

        [Test]
        public void Test6()
        {
            var input = "bbbbbbbbbbbbbbbbbbbbbbbbbbbabbbbbbbbbbbbbbbccbcbcbccbbabbb";
            var output = Problem1750.MinimumLength(input);
        }
    }
}
