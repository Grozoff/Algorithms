namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/container-with-most-water">Container With Most Water</see>
    /// <br>Array, Two Pointers, Greedy</br>
    /// </summary>
    internal class Problem0011
    {
        public static int MaxArea(int[] height)
        {
            var initialLength = height.Length - 1;
            var p1 = 0;
            var p2 = height.Length - 1;
            var max = Math.Min(height[p1], height[p2]) * initialLength;
            while (p1 < p2)
            {
                if (height[p1] < height[p2])
                {
                    p1++;
                    initialLength--;
                }
                else if (height[p1] > height[p2])
                {
                    p2--;
                    initialLength--;
                }
                else
                {
                    p1++;
                    p2--;
                    initialLength -= 2;
                }

                max = Math.Max(max, Math.Min(height[p1], height[p2]) * initialLength);
            }

            return max;
        }
    }

    public class Tests0011
    {

        [Test]
        public void Test1()
        {
            int[] input = [1, 8, 6, 2, 5, 4, 8, 3, 7];
            var output = Problem0011.MaxArea(input);
            Assert.That(output, Is.EqualTo(49));
        }
    }
}
