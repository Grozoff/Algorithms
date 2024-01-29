namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/shuffle-an-array">Shuffle an Array</see>
    /// <br>Array, Math, Randomized</br>
    /// </summary>
    internal class Problem0384
    {
        private readonly int[] _temp;
        private readonly int[] _nums;
        private readonly Random _random = new Random();

        public Problem0384(int[] nums)
        {
            _temp = nums.ToArray();
            _nums = nums;
        }

        public int[] Reset()
        {
            return _temp;
        }

        public int[] Shuffle()
        {
            _random.Shuffle(_nums);
            return _nums;
        }
    }
}
