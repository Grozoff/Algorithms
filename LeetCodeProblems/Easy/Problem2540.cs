namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/minimum-common-value/">Minimum Common Value</see>
    /// <br>Array, Hash Table, Two Pointers, Binary Search</br>
    /// </summary>
    internal class Problem2540
    {
        public int GetCommon(int[] nums1, int[] nums2)
        {
            return nums1.Intersect(nums2).FirstOrDefault(-1);

            // not my solution
            var arr1 = 0;
            var arr2 = 0;

            while (arr1 < nums1.Length && arr2 < nums2.Length)
            {
                var num1 = nums1[arr1];
                var num2 = nums2[arr2];

                if (num1 == num2) return num1;

                if (num1 < num2) arr1++;
                else arr2++;
            }

            return -1;
        }
    }
}
