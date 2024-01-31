namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/daily-temperatures">Daily Temperatures</see>
    /// <br>Array, Stack, Monotonic Stack</br>
    /// </summary>
    internal class Problem0739
    {
        public static int[] DailyTemperatures(int[] temperatures)
        {
            var result = new int[temperatures.Length];
            var stack = new Stack<(int, int)>();
            stack.Push((temperatures[0], 0));

            for (int i = 1; i < temperatures.Length; i++)
            {
                while (stack.Count !=0 && stack.Peek().Item1 < temperatures[i])
                {
                    result[stack.Peek().Item2] = i - stack.Pop().Item2;
                }

                stack.Push((temperatures[i], i));
            }

            return result;
        }
    }

    public class Tests0739
    {
        [Test]
        public void Test1()
        {
            int[] s = [73, 74, 75, 71, 69, 72, 76, 73];
            var output = Problem0739.DailyTemperatures(s);
        }
    }
}
