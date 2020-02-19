using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        ///  Sort the Matrix Diagonally (Mine)
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public static int[][] DiagonalSort(int[][] mat)
        {
            int m = mat.Length, n = mat[0].Length;
            for (int i = 0; i < m; i++)
                Sort(i, 0);
            for (int j = 1; j < n; j++)
                Sort(0, j);

            return mat;
            
            void Sort(int i, int j)
            {
                var list = new List<int>();

                int i1 = i, j1 = j;
                while (i1 < m && j1 < n)
                {
                    list.Add(mat[i1][j1]);
                    i1++;
                    j1++;
                }
                
                list.Sort();

                i1 = i;
                j1 = j;
                int index = 0;
                while (index < list.Count)
                {
                    mat[i1][j1] = list[index];
                    i1++;
                    j1++;
                    index++;
                }
            }
        }
    }
}