using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Spiral Matrix
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> list = new List<int>();

            if (matrix.Length == 0)
                return list;

            int i = 0, j = 0;
            int m = matrix.Length, n = matrix[0].Length, listCount = m * n;
            bool inRow = true, inCol = false, inRevRow = false, inRevCol = false;
            int inRowCount = 0, inColCount = 0, inRevRowCount = 0, inRevColCount = 0;

            while (true)
            {
                if (list.Count == listCount)
                    break;
                list.Add(matrix[i][j]);
                if (inRow)
                {
                    if (j == n - 1 - inColCount)
                    {
                        inCol = true;
                        inRow = false;
                        i++;
                        inRowCount++;
                    }
                    else j++;
                }
                else if (inCol)
                {
                    if (i == m - 1 - inRevRowCount)
                    {
                        inCol = false;
                        inRevRow = true;
                        j--;
                        inColCount++;
                    }
                    else i++;
                }
                else if (inRevRow)
                {
                    if (j == inRevColCount)
                    {
                        inRevRow = false;
                        inRevCol = true;
                        i--;
                        inRevRowCount++;
                    }
                    else j--;
                }
                else if (inRevCol)
                {
                    if (i == inRowCount)
                    {
                        inRevCol = false;
                        inRow = true;
                        j++;
                        inRevColCount++;
                    }
                    else i--;
                }
            }

            return list;
        }
    }
}
