namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/isomorphic-strings">Isomorphic Strings</see>
    /// <br>Array, String, Backtracking, Matrix</br>
    /// </summary>
    internal class Problem0079
    {
        public bool Exist(char[][] board, string word)
        {
            int boardLen = board.Length;

            for (var i = 0; i < boardLen; i++)
            {
                var lineLen = board[i].Length;

                for (var j = 0; j < lineLen; j++)
                {
                    if (DepthFirstSearch(board, i, j, word, 0))
                        return true;
                }
            }

            return false;
        }

        private bool DepthFirstSearch(char[][] board, int i, int j, string word, int index)
        {
            if (index == word.Length)
                return true;

            if (i < 0 || i >= board.Length || j < 0 || j >= board[i].Length || board[i][j] != word[index])
                return false;

            var temp = board[i][j];
            board[i][j] = '#';

            bool match =
                DepthFirstSearch(board, i + 1, j, word, index + 1) ||
                DepthFirstSearch(board, i - 1, j, word, index + 1) ||
                DepthFirstSearch(board, i, j + 1, word, index + 1) ||
                DepthFirstSearch(board, i, j - 1, word, index + 1);

            board[i][j] = temp;
            return match;
        }
    }
}
