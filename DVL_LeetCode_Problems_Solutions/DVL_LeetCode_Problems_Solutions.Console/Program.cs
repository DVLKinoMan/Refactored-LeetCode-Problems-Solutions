using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVL_LeetCode_Problems_Solutions.Domain;

using static DVL_LeetCode_Problems_Solutions.Console.Tester;
using static System.Console;

namespace DVL_LeetCode_Problems_Solutions.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //ThreeSum(new int[] {4, 4, 4, 4, 4, 3, 23, 2, 2});

            //Solve N Queens
            //SolveNQueensTester(10);


            //Solve N Queens II
            //SolveNQueens2TesterNotMine(10);

            //Sudoku Solver
            //var board = new Char[][]
            //{
            //    new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
            //    new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
            //    new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
            //    new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
            //    new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
            //    new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
            //    new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
            //    new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
            //    new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
            //};
            //SolveSudokuTester(board);

            //FirstMissingPositiveSolver(new int[] {0, 3, 4, 2, 1, 5, 6});

            //MultiplyStringsTester("140", "721");

            //int len = LengthOfLastWordTester("kldfleja  oldjfj  ");

            //TrapTester(new int[] {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1});

            //WildCardMatchingTetser();

            //ProblemSolver.CanThreePartsEqualSum(new int[]{3, 3, 6, 5, -2, 2, 5, 1, -9, 4 });

            PermutationIITester(new int[] {1, 1, 2});

            ReadKey();
        }
    }
}
 