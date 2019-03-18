//using System;
//using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Sudoku Solver
        /// </summary>
        /// <param name="board"></param>
        public static void SolveSudoku(char[][] board)
        {
            //var coordinates = board.SelectMany((b,i) => b.Where(ch => ch == '.').Select((ch, j) => Tuple.Create(i,j))).ToList();
            //var coordinates = new List<Tuple<int, int>>();
            //for (int i = 0; i < 9; i++)
            //    for (int j = 0; j < 9; j++)
            //        if (board[i][j] == '.')
            //            coordinates.Add(Tuple.Create(i, j));

            RecursionForSudoku(0, 0, board);
        }

        //Deprecated
        //private static bool RecursionForSudoku(char[][] board, List<Tuple<int, int>> list)
        //{
        //    if (list.Count == 0)
        //        return true;

        //    var l = list.First();
        //    list.RemoveAt(0);
        //    foreach (var ch in Enumerable.Range('1', 9).Select(num => (char) num))
        //        if (IsValidSudokuBoard(board, l, ch))
        //        {
        //            board[l.Item1][l.Item2] = ch;
        //            if (RecursionForSudoku(board, list))
        //                return true;
        //        }

        //    list.Insert(0, l);
        //    board[l.Item1][l.Item2] = '.';

        //    return false;
        //}

        private static bool RecursionForSudoku(int rowIndex, int colIndex, char[][] board)
        {
            if (rowIndex == 9 && ++colIndex == 9)
                return true;

            if (rowIndex == 9)
                rowIndex = 0;

            if (board[rowIndex][colIndex] != '.')
                return RecursionForSudoku(rowIndex + 1, colIndex, board);

            foreach (var ch in Enumerable.Range('1', 9).Select(num => (char)num))
                if (IsValidSudokuBoard(board, rowIndex, colIndex, ch))
                {
                    board[rowIndex][colIndex] = ch;
                    if (RecursionForSudoku(rowIndex+1, colIndex, board))
                        return true;
                }
            
            board[rowIndex][colIndex] = '.';

            return false;
        }

        //Deprecated
        //private static bool IsValidSudokuBoard(char[][] board, Tuple<int,int> coordinate, char ch)
        //{
        //    for (int i = 0; i < 9; i++)
        //        if (board[i][coordinate.Item2] == ch || board[coordinate.Item1][i] == ch)
        //            return false;

        //    //for (int i = 0; i < 9; i++)
        //    //    for (int j = 0; j < 9; j++)
        //    //        if (!(i==coordinate.Item1 && j==coordinate.Item2) && Math.Abs(i - coordinate.Item1) == Math.Abs(j - coordinate.Item2) && board[i][j] == ch)
        //    //            return false;

        //    int iStart = coordinate.Item1 / 3 * 3, iEnd = iStart + 3;
        //    int jStart = coordinate.Item2 / 3 * 3, jEnd = jStart + 3;
        //    for(int i= iStart; i<iEnd;i++)
        //        for(int j=jStart;j<jEnd;j++)
        //            if (!(i == coordinate.Item1 && j == coordinate.Item2) && board[i][j] == ch)
        //                return false;

        //    return true;
        //}

        private static bool IsValidSudokuBoard(char[][] board, int rowIndex, int colIndex, char ch)
        {
            for (int i = 0; i < 9; i++)
                if (board[i][colIndex] == ch || board[rowIndex][i] == ch)
                    return false;

            //for (int i = 0; i < 9; i++)
            //    for (int j = 0; j < 9; j++)
            //        if (!(i==coordinate.Item1 && j==coordinate.Item2) && Math.Abs(i - coordinate.Item1) == Math.Abs(j - coordinate.Item2) && board[i][j] == ch)
            //            return false;

            int iStart = rowIndex / 3 * 3, iEnd = iStart + 3;
            int jStart = colIndex / 3 * 3, jEnd = jStart + 3;
            for (int i = iStart; i < iEnd; i++)
                for (int j = jStart; j < jEnd; j++)
                    if (!(i == rowIndex && j == colIndex) && board[i][j] == ch)
                        return false;

            return true;
        }
    }
}
