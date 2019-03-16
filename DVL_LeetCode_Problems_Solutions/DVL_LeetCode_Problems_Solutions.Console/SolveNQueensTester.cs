using static System.Console;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LeetCode_Problems_Solutions.Console
{
    partial class Tester
    {
        public static void SolveNQueensTester(int n)
        {
            int count = 1;
            foreach (var list in SolveNQueens(n))
            {
                WriteLine(count);
                foreach (var str in list)
                    WriteLine(str);
                count++;
            }
        }
    }
}
