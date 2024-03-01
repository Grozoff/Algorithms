namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/find-the-difference-of-two-arrays'>Find the Difference of Two Arrays</see>
    /// <br>Array, Hash Table</br>
    /// </summary>
    internal class Problem2215
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            return [nums1.Except(nums2).ToList(), nums2.Except(nums1).ToList()];

            // not my solution
            var set1 = new HashSet<int>(nums1);
            var set2 = new HashSet<int>(nums2);
            set2.ExceptWith(nums1);
            set1.ExceptWith(nums2);
            return new List<IList<int>> { set1.ToList(), set2.ToList() };
        }
    }
}
