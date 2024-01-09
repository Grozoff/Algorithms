namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/">Best Time to Buy and Sell Stock II</see>
    /// <br>Array, Dynamic Programming, Greedy</br>
    /// </summary>
    public class Problem0122
    {
        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                profit = prices[i] - prices[i - 1];

                if (profit > 0)
                {
                    maxProfit += profit;
                }
            }

            return maxProfit;
        }
    }

    public class Tests122
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var input = new[] { 7, 1, 5, 3, 6, 4 };
            var output = Problem0122.MaxProfit(input);

            Assert.That(7, Is.EqualTo(output));
        }

        [Test]
        public void Test2()
        {
            var input = new[] { 1, 2, 3, 4, 5 };
            var output = Problem0122.MaxProfit(input);

            Assert.That(4, Is.EqualTo(output));
        }

        [Test]
        public void Test3()
        {
            var input = new[] { 7, 6, 4, 3, 1 };
            var output = Problem0122.MaxProfit(input);

            Assert.That(0, Is.EqualTo(output));
        }
    }
}
