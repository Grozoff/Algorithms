namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/maximum-odd-binary-number'>Maximum Odd Binary Number</see>
    /// <br>Math, String, Greedy</br>
    /// </summary>
    internal class Problem2864
    {
        public static string MaximumOddBinaryNumber(string s)
        {
            var bits = s.ToCharArray();
            Array.Sort(bits);
            Array.Reverse(bits);

            for (int i = 0; i < bits.Length-1; i++)
            {
                if (bits[i+1] == '0')
                {
                    bits[i] = '0';
                    bits[^1] = '1';
                }
            }

            return new string(bits);

            // not my solution
            var zeros = s.Count(c => c == '0');
            var ones = s.Count(c => c == '1');

            return
                new String('1', ones - 1) +
                new String('0', zeros) +
                new String('1', 1);
        }
    }

    public class Tests2864
    {

        [Test]
        public void Test1()
        {
            var input = "0101";
            var output = Problem2864.MaximumOddBinaryNumber(input);
            Assert.That(output, Is.EqualTo("1001"));
        }

        [Test]
        public void Test2()
        {
            var input = "00111";
            var output = Problem2864.MaximumOddBinaryNumber(input);
            Assert.That(output, Is.EqualTo("11001"));
        }

        [Test]
        public void Test3()
        {
            var input = "111";
            var output = Problem2864.MaximumOddBinaryNumber(input);
            Assert.That(output, Is.EqualTo("111"));
        }
    }
}
