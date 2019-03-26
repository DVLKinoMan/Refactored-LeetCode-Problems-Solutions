using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        public static void Rotate(int[][] matrix)
        {
            int n = matrix.Length;
            int i = 0, j = 0;
            int c = 0;
            int temp = 0;
            while (true)
            {
                int temp2 = matrix[i][j];
                matrix[i][j] = temp;
                temp = matrix[i][j + n - 1];
                matrix[i][j + n - 1] = temp2;
                c++;
            }
        }

        //private static Tuple<int, int> CalcNextCoordinate(int i, int j, int c, int n)
        //{

        //    n-c*2
        //    int c = j >= n / 2 ? n - j - 1 : j;


        //}
    }
}
