using System.Text;

namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/make-the-string-great">Make The String Great</see>
    /// <br>String, Stack</br>
    /// </summary>
    internal class Problem1544
    {
        public static string MakeGood(string s)
        {
            var str = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (str.Count == 0 || str.Peek() - s[i] != 32)
                    str.Push(s[i]);
                else
                    str.Pop();
            }

            return new string(str.Reverse().ToArray());

            // the same with sb
            var sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (sb.Length > 0 && Math.Abs(sb[^1] - s[i]) == 32)
                    sb.Length--;
                else
                    sb.Append(s[i]);
            }

            return sb.ToString();
        }
    }

    public class Tests1544
    {
        [Test]
        public void Test1()
        {
            
            var input = "Leetcode";
            var output = Problem1544.MakeGood(input);

            Assert.That("Leetcode", Is.EqualTo(output));
        }
    }
}
