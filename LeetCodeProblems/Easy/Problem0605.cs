namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/can-place-flowers">Can Place Flowers</see>
    /// <br>Array, Greedy</br>
    /// </summary>
    internal class Problem0605
    {
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    var elp = (i == 0) || (flowerbed[i - 1] == 0);
                    var erp = (i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0);

                    if (elp && erp)
                    {
                        flowerbed[i] = 1;
                        n--;
                        if (n == 0)
                            return true;
                    }
                }
            }
            return n <= 0;
        }
    }

    public class Tests0605
    {

        [Test]
        public void Test1()
        {
            int[] input = [1, 0, 0, 0, 1];
            var output = Problem0605.CanPlaceFlowers(input, 2);
        }

        [Test]
        public void Test2()
        {
            int[] input = [1, 0, 0, 0, 1, 0, 0];
            var output = Problem0605.CanPlaceFlowers(input, 2);
        }
    }
}
