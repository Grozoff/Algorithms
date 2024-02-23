using System.Text;

namespace LeetCodeProblems
{
    internal class Problem0443
    {
        public static int Compress(char[] chars)
        {
            if (chars.Length == 1) return 1;
            var sb = new StringBuilder();
            sb.Append(chars[0]);
            var sum = 1;
            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] == chars[i - 1])
                {
                    sum++;
                }
                else
                {
                    if(sum > 1)
                        sb.Append(sum);
                    sb.Append(chars[i]);
                    sum = 1;
                }
            }
            if (sum > 1)
                sb.Append(sum);
            var str = sb.ToString().ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (i == str.Length)
                {
                    break;
                }
                chars[i] = str[i];
            }

            return sb.Length;
        }
    }

    public class Tests0443
    {
        [Test]
        public void Test1()
        {
            char[] s = ['a', 'a', 'b', 'b', 'c', 'c', 'c'];
            var output = Problem0443.Compress(s);
        }

        [Test]
        public void Test2()
        {
            char[] s = ['a', 'a', 'a', 'b', 'b', 'a', 'a'];
            var output = Problem0443.Compress(s);
        }
    }
}
