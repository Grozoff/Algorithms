namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/minimum-falling-path-sum/">Minimum Falling Path Sum</see>
    /// <br>Array, Dynamic Programming, Matrix</br>
    /// </summary>
    internal class Problem0931
    {
        public static int MinFallingPathSum(int[][] matrix)
        {
            // not my solution
            for (int r = 1; r < matrix.Length; r++)
            {
                for(int c = 0; c < matrix.Length; c++)
                {
                    var mid = matrix[r - 1][c];
                    var left = c > 0 ? matrix[r - 1][c - 1] : int.MaxValue;
                    var right = c < matrix.Length - 1 ? matrix[r - 1][c + 1] : int.MaxValue;
                    matrix[r][c] = matrix[r][c] + Math.Min(mid, Math.Min(left, right));
                }
            }
            GC.Collect();
            return matrix[^1].Min();
        }
    }

    public class Tests0931
    {
        [Test]
        public void Test1()
        {
            int[][] s = [[2, 1, 3], [6, 5, 4], [7, 8, 9]];
            var output = Problem0931.MinFallingPathSum(s);

            Assert.That(output, Is.EqualTo(13));
        }

        [Test]
        public void Test2()
        {
            int[][] s = [[-19, 57], [-40, -5]];
            var output = Problem0931.MinFallingPathSum(s);

            Assert.That(output, Is.EqualTo(-59));
        }
    }
}
