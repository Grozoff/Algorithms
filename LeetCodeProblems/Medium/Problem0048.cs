namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/rotate-image/">Rotate Image</see>
    /// <br>Array, Math, Matrix</br>
    /// </summary>
    internal class Problem0048
    {
        public static void Rotate(int[][] matrix)
        {
            int length = matrix.Length;
            if (length < 2)
                return;

            var end = matrix.Length - 1;

            for (int i = 0; i < length / 2; i++)
            {
                for (int j = i; j < length - i - 1; j++)
                {
                    // swap using tuple: https://www.reddit.com/r/ProgrammerTIL/comments/8ssiqb/comment/e12301f/
                    (matrix[j][end - i], matrix[i][j], matrix[end - j][i], matrix[end - i][end - j]) =
                        (matrix[i][j], matrix[end - j][i], matrix[end - i][end - j], matrix[j][end - i]);

                    // without tuple
                    //var tmp = matrix[j][end - i];
                    //matrix[j][end - i] = matrix[i][j];
                    //matrix[i][j] = matrix[end - j][i];
                    //matrix[end - j][i] = matrix[end - i][end - j];
                    //matrix[end - i][end - j] = tmp;
                }
            }
        }
    }

    public class Tests48
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var input = new int[][]
            {
                [1, 2, 3],
                [4, 5, 6],
                [7, 8, 9]
            };
            var result = new int[][]
            {
                [7, 4, 1],
                [8, 5, 2],
                [9, 6, 3]
            };

            Problem0048.Rotate(input);

            Assert.That(result, Is.EqualTo(input));
        }

        [Test]
        public void Test2()
        {
            var input = new int[][] { [5, 1, 9, 11], [2, 4, 8, 10], [13, 3, 6, 7], [15, 14, 12, 16] };
            var result = new int[][] { [15, 13, 2, 5], [14, 3, 4, 1], [12, 6, 8, 9], [16, 7, 10, 11] };

            Problem0048.Rotate(input);

            Assert.That(result, Is.EqualTo(input));
        }
    }
}
