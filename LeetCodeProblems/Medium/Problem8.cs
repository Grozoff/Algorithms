using System.Text;

namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/string-to-integer-atoi/">String to Integer (atoi)</see>
    /// <br>String</br>
    /// </summary>
    internal class Problem8
    {
        public static int MyAtoi(string s)
        {
            var ss = s.Trim();
            if (ss.Length == 0)
                return 0;

            var sign = string.Empty;

            if (ss[0] == '+' || ss[0] == '-')
            {
                sign = ss[0].ToString();
            }

            var startIndex = string.IsNullOrEmpty(sign) ? 0 : 1;
            if (ss.Length != startIndex && char.IsDigit(ss[startIndex]))
            {
                var sb = new StringBuilder();
                for (int i = startIndex; i < ss.Length; i++)
                {
                    if (char.IsDigit(ss[i]))
                    {
                        sb.Append(ss[i]);
                        continue;
                    }

                    break;
                }
                var stringNumber = sb.ToString();
                var isNegative = sign == "-";
                var isItn32 = int.TryParse(stringNumber, out int intNumber);
                return isItn32 ? isNegative ? intNumber * -1 : intNumber : isNegative ? int.MinValue : int.MaxValue;
            }

            return 0;
        }
    }

    public class Tests8
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var input = "42";
            var output = Problem8.MyAtoi(input);
            Assert.That(output, Is.EqualTo(42));
        }

        [Test]
        public void Test2()
        {
            var input = "   -42";
            var output = Problem8.MyAtoi(input);
            Assert.That(output, Is.EqualTo(-42));
        }

        [Test]
        public void Test3()
        {
            var input = "4193 with words";
            var output = Problem8.MyAtoi(input);
            Assert.That(output, Is.EqualTo(4193));
        }

        [Test]
        public void Test4()
        {
            var input = "with words -4193";
            var output = Problem8.MyAtoi(input);
            Assert.That(output, Is.EqualTo(0));
        }

        [Test]
        public void Test5()
        {
            var input = ".1";
            var output = Problem8.MyAtoi(input);
            Assert.That(output, Is.EqualTo(0));
        }
    }
}
