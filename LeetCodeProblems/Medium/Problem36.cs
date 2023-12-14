namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/valid-sudoku/'>Valid Sudoku</see>
    /// <br>Array, Hash Table, Matrix</br>
    /// </summary>
    internal class Problem36
    {
        public static bool IsValidSudoku(char[][] board)
        {
            var column = new Dictionary<char, int>();
            var line = new Dictionary<char, int>();
            var subboxes = new HashSet<char>[9];

            for (int i = 0; i < 9; i++)
            {
                subboxes[i]= new HashSet<char>();
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[j][i] != '.')
                    {
                        if (!column.TryAdd(board[j][i], i))
                        {
                            return false;
                        }
                    }

                    if (board[i][j] != '.')
                    {
                        if (!line.TryAdd(board[i][j], j))
                        {
                            return false;
                        }

                        int b = (3 * (i / 3)) + (j / 3);
                        if (!subboxes[b].Add(board[i][j]))
                        {
                            return false;
                        }
                    }
                }

                column.Clear();
                line.Clear();
            }

            return true;
        }
    }

    public class Tests36
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var input = new char[][]
            {
                 ['5','3','.','.','7','.','.','.','.']
                ,['6','.','.','1','9','5','.','.','.']
                ,['.','9','8','.','.','.','.','6','.']
                ,['8','.','.','.','6','.','.','.','3']
                ,['4','.','.','8','.','3','.','.','1']
                ,['7','.','.','.','2','.','.','.','6']
                ,['.','6','.','.','.','.','2','8','.']
                ,['.','.','.','4','1','9','.','.','5']
                ,['.','.','.','.','8','.','.','7','9']
            };
            var output = Problem36.IsValidSudoku(input);
            Assert.That(output, Is.True);
        }

        [Test]
        public void Test2()
        {
            var input = new char[][]
            {
                 ['8','3','.','.','7','.','.','.','.']
                ,['6','.','.','1','9','5','.','.','.']
                ,['.','9','8','.','.','.','.','6','.']
                ,['8','.','.','.','6','.','.','.','3']
                ,['4','.','.','8','.','3','.','.','1']
                ,['7','.','.','.','2','.','.','.','6']
                ,['.','6','.','.','.','.','2','8','.']
                ,['.','.','.','4','1','9','.','.','5']
                ,['.','.','.','.','8','.','.','7','9']
            };
            var output = Problem36.IsValidSudoku(input);
            Assert.That(output, Is.False);
        }

        [Test]
        public void Test3()
        {
            var input = new char[][]
            {
                 ['5','3','.','.','7','.','.','.','.']
                ,['6','.','.','1','9','5','.','.','.']
                ,['.','9','8','.','.','.','.','6','.']
                ,['8','.','.','.','6','.','.','.','3']
                ,['4','.','.','8','.','3','.','.','1']
                ,['7','4','.','.','2','.','.','.','6']
                ,['.','6','.','.','.','.','2','8','.']
                ,['.','.','.','4','1','9','.','.','5']
                ,['.','.','.','.','8','.','.','7','9']
            };
            var output = Problem36.IsValidSudoku(input);
            Assert.That(output, Is.False);
        }
    }
}
