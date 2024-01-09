namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/move-zeroes/">Move Zeroes</see>
    /// <br>Array, Two Pointers</br>
    /// </summary>
    internal class Problem0283
    {
        public void MoveZeroes(int[] nums)
        {
            if (!nums.Contains(0))
            {
                return;
            }
            else
            {
                var a = nums.Where(x => x != 0).ToArray();

                for (int i = 0; i < a.Length; i++)
                {
                    nums[i] = a[i];
                }

                var zeroCount = nums.Length - a.Length;
                for (int i = nums.Length - 1; i >= 0; i--)
                {
                    if (zeroCount == 0)
                    {
                        break;
                    }
                    nums[i] = 0;
                    zeroCount--;
                }
            }
        }
    }
}
