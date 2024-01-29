namespace LeetCodeProblems.Medium
{
    internal class Problem0204
    {
        public static int CountPrimes(int n)
        {
            var count = 0;
            var isComposite = new bool[n + 1];

            for (var i = 2; i < n; i++)
            {
                if (isComposite[i])
                {
                    continue;
                }

                count++;

                for (var j = i * 2; j < n; j += i)
                {
                    isComposite[j] = true;
                }
            }

            return count;
        }
    }

    public class Tests0204
    {
        [Test]
        public void Test1()
        {
            var n = 2;
            var output = Problem0204.CountPrimes(n);

            Assert.That(output, Is.EqualTo(0));
        }

        [Test]
        public void Test2()
        {
            var n = 3;
            var output = Problem0204.CountPrimes(n);

            Assert.That(output, Is.EqualTo(1));
        }
    }
}
