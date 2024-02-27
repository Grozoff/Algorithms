namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/max-number-of-k-sum-pairs">Max Number of K-Sum Pairs</see>
    /// <br>Array, Hash Table, Two Pointers, Sorting</br>
    /// </summary>
    internal class Problem1679
    {
        public static int MaxOperations(int[] nums, int k)
        {
            var map = new Dictionary<int, int>();
            var answer = 0;
            foreach (int num in nums)
            {
                if (map.ContainsKey(k - num) && map[k - num] > 0)
                {
                    map[k - num]--;
                    answer++;
                }
                else
                {
                    if (!map.ContainsKey(num))
                        map[num] = 0;
                    map[num]++;
                }
            }
            return answer;
        }
    }

    public class Tests1679
    {
        [Test]
        public void Test1()
        {
            int[] input = [4,4,1,3,1,3,2,2,5,5,1,5,2,1,2,3,5,4];
            var k = 2;
            var output = Problem1679.MaxOperations(input, k);

            Assert.True(output == 2);
        }
    }
}
