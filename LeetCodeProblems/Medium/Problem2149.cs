namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/rearrange-array-elements-by-sign/'>Rearrange Array Elements by Sign</see>
    /// <br>Array, Two Pointers, Simulation</br>
    /// </summary>
    internal class Problem2149
    {
        public static int[] RearrangeArray(int[] nums)
        {
            // efficient by memory
            var pos = nums.Where(x => x > 0).ToList();
            var neg = nums.Where(x => x < 0).ToList();

            var result = new int[nums.Length];
            var index = 0;
            var index2 = 1;
            for (int i = 0; i < nums.Length / 2; i++)
            {
                result[index] = pos[i];
                result[index2] = neg[i];
                index2 += 2;
                index +=2;
            }

            return result;

            // efficient by runtime
            int pos1 = 0;
            int neg2 = 1;
            int[] arr = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    arr[neg2] = nums[i];
                    neg2 += 2;
                }
                else if (nums[i] > 0)
                {
                    arr[pos1] = nums[i];
                    pos1 += 2;
                }
            }
            return arr;
        }
    }

    public class Tests2149
    {
        [Test]
        public void Test1()
        {
            var input = new[] { 3, 1, -2, -5, 2, -4 };
            var output = Problem2149.RearrangeArray(input);
        }

        [Test]
        public void Test2()
        {
            var input = new[] { -1, 1 };
            var output = Problem2149.RearrangeArray(input);
        }
    }
}
