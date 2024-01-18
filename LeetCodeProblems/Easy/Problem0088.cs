namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/merge-sorted-array/'>Merge Sorted Array</see>
    /// <br>Array, Two Pointers, Sorting</br>
    /// </summary>
    internal class Problem0088
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }
            Array.Sort(nums1);
        }
    }
    public class Tests0088
    {
        [Test]
        public void Test1()
        {

            int[] nums1 = [1, 2, 3, 0, 0, 0];
            var m = 3;
            int[] nums2 = [2, 5, 6];
            var n = 3;
            Problem0088.Merge(nums1, m, nums2, n);
        }
    }
}
