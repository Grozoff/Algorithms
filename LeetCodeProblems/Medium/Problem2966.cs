namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/divide-array-into-arrays-with-max-difference'>Divide Array Into Arrays With Max Difference</see>
    /// <br>Array, Greedy, Sorting</br>
    /// </summary>
    internal class Problem2966
    {
        public int[][] DivideArray(int[] nums, int k)
        {
            if (nums.Length % 3 != 0)
                return [];

            Array.Sort(nums);

            var a = nums.Chunk(3).ToArray();

            foreach ( var i in a )
            {
                if (i[2] - i[0] > k)
                    return [];
            }

            return a;
        }
    }
}
