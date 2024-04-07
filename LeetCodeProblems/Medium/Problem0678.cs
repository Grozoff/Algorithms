namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/valid-parenthesis-string">Valid Parenthesis String</see>
    /// <br>String, Dynamic Programming, Stack, Greedy</br>
    /// </summary>
    internal class Problem0678
    {
        public static bool CheckValidString(string s)
        {
            var min = 0;
            var max = 0;
            foreach (var c in s)
            {
                if (c == '(')
                {
                    min++;
                    max++;
                }
                else if (c == ')')
                {
                    min--;
                    max--;
                }
                else
                {
                    min--;
                    max++;
                }

                // or
                //min+= c=='(' ? 1 : -1;
                //max+= c==')' ? -1 : 1;

                if (min < 0)
                    min = 0;
                if (max < 0)
                    return false;
            }

            return min == 0;
        }
    }
    public class Tests0678
    {
        [Test]
        public void Test1()
        {
            var s = "()";
            var output = Problem0678.CheckValidString(s);

            Assert.That(output, Is.EqualTo(true));
        }

        [Test]
        public void Test2()
        {
            var s = "(*)";
            var output = Problem0678.CheckValidString(s);

            Assert.That(output, Is.EqualTo(true));
        }

        [Test]
        public void Test3()
        {
            var s = "(*))";
            var output = Problem0678.CheckValidString(s);

            Assert.That(output, Is.EqualTo(true));
        }

        [Test]
        public void Test4()
        {
            var s = "(((((*)))**";
            var output = Problem0678.CheckValidString(s);

            Assert.That(output, Is.EqualTo(true));
        }
    }
}
