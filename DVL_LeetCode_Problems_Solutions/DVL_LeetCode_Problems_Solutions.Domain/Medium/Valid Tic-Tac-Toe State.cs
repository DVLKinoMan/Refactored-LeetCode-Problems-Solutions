namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Valid Tic-Tac-Toe State (Mine)
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        public static bool ValidTicTacToe(string[] board)
        {
            int xCount = 0, oCount = 0;
            for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
            {
                if (board[i][j] == 'X')
                    xCount++;
                else if (board[i][j] == 'O')
                    oCount++;
            }

            if (xCount == 0 && oCount == 0)
                return true;

            if (xCount < oCount || xCount - 1 > oCount)
                return false;

            int xWonInRowCount = 0, oWonInRowCount = 0, 
                xWonInColCount = 0, oWonInColCount = 0,
                xWonInDiagonal = 0, oWonInDiagonal = 0;
            for (int i = 0; i < 3; i++)
            {
                bool xWonInRow = board[i][0] == 'X',
                    oWonInRow = board[i][0] == 'O',
                    xWonInCol = board[0][i] == 'X',
                    oWonInCol = board[0][i] == 'O';
                for (int j = 0; j < 3; j++)
                {
                    if (j != 0 && board[i][j] != board[i][j - 1])
                        xWonInRow = oWonInRow = false;
                    if (j != 0 && board[j][i] != board[j - 1][i])
                        xWonInCol = oWonInCol = false;
                }

                xWonInRowCount += xWonInRow ? 1 : 0;
                xWonInColCount += xWonInCol ? 1 : 0;
                oWonInRowCount += oWonInRow ? 1 : 0;
                oWonInColCount += oWonInCol ? 1 : 0;
            }

            if (xWonInRowCount > 1 || xWonInColCount > 1 || oWonInRowCount > 1 || oWonInColCount > 1)
                return false;

            bool isEqualInDiagonal = board[0][0] == board[1][1] && board[1][1] == board[2][2];
            if (isEqualInDiagonal)
            {
                if (board[0][0] == 'X')
                    xWonInDiagonal++;
                else if (board[0][0] == 'O')
                    oWonInDiagonal++;
            }

            isEqualInDiagonal = board[2][0] == board[1][1] && board[1][1] == board[0][2];
            if (isEqualInDiagonal)
            {
                if (board[2][0] == 'X')
                    xWonInDiagonal++;
                else if (board[2][0] == 'O')
                    oWonInDiagonal++;
            }

            if (xWonInDiagonal > 0 && oWonInDiagonal > 0)
                return false;

            int allXWonCount = xWonInColCount + xWonInRowCount + xWonInDiagonal;
            int allOWonCount = oWonInColCount + oWonInRowCount + oWonInDiagonal;

            if (allXWonCount > 0 && xCount == oCount)
                return false;

            if (xCount > oCount && allOWonCount > 0)
                return false;

            return allXWonCount == 0 || allOWonCount == 0;
        }
    }
}
