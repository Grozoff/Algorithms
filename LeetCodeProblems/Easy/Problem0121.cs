namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/best-time-to-buy-and-sell-stock/">Best Time to Buy and Sell Stock</see>
    /// <br>Array, Dynamic Programming</br>
    /// </summary>
    internal class Problem0121
    {
        public static int MaxProfit(int[] prices)
        {
            var maxProfit = 0;
            var cheapest = prices[0];
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < cheapest)
                {
                    cheapest = prices[i];
                }

                var profit = prices[i] - cheapest;

                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }
            GC.Collect();
            return maxProfit;
        }
    }

    public class Tests0121
    {
        [Test]
        public void Test1()
        {
            var input = new[] { 7, 1, 5, 3, 6, 4 };
            var output = Problem0121.MaxProfit(input);

            Assert.That(5, Is.EqualTo(output));
        }
    }
}
