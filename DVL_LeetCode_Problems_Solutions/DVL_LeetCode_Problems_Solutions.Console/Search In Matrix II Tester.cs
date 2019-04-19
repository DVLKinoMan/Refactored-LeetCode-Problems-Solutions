using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LeetCode_Problems_Solutions.Console
{
    partial class Tester
    {
        public static void SearchA2DMatrixIITester()
        {
            var matrix = new int[,]
            {
                {1, 4, 7, 11, 15},
                {2, 5, 8, 12, 19},
                {3, 6, 9, 16, 22},
                {10, 13, 14, 17, 24},
                {18, 21, 23, 26, 30}
            };
            int target = 4;
            System.Console.WriteLine(SearchMatrix(matrix, target));
        }
    }
}
