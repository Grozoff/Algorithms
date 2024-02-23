namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/product-of-array-except-self'>Product of Array Except Self</see>
    /// <br>Array, Prefix Sum</br>
    /// </summary>
    internal class Problem0238
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            var answer = new int[nums.Length];
            var num = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                answer[i] = num;
                num *= nums[i];
            }

            num = 1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                answer[i] *= num;
                num *= nums[i];
            }

            return answer;
        }
    }

    public class Tests0238
    {
        [Test]
        public void Test1()
        {
            int[] s = [1, 2, 3, 4];
            var output = Problem0238.ProductExceptSelf(s);
        }

        [Test]
        public void Test2()
        {
            int[] s = [4, 3, 2, 1, 2];
            var output = Problem0238.ProductExceptSelf(s);
        }
    }
}
