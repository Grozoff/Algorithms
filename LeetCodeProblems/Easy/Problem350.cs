namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/intersection-of-two-arrays-ii">Intersection of Two Arrays II</see>
    /// <br>Array, Hash Table, Two Pointers, Binary Search, Sorting</br>
    /// </summary>
    internal class Problem350
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var result = new List<int>();

            if (nums1.Length < nums2.Length)
            {
                var nums22 = nums2.ToList();
                for (int i = 0; i < nums1.Length; i++)
                {
                    if (nums22.Remove(nums1[i]))
                    {
                        result.Add(nums1[i]);
                    }
                }
            }
            else
            {
                var nums11 = nums1.ToList();
                for (int i = 0; i < nums2.Length; i++)
                {
                    if (nums11.Remove(nums2[i]))
                    {
                        result.Add(nums2[i]);
                    }
                }
            }

            return result.ToArray();
        }
    }
}
