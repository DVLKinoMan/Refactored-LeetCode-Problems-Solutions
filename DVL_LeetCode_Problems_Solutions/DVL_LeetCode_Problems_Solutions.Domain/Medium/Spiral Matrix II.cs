namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Spiral Matrix II
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[][] GenerateMatrix(int n)
        {
            var result = new int[n][];

            for (int index0 = 0; index0 < n; index0++)
                result[index0] = new int[n];
            
            int i = 0, j = 0;
            int m = n, n2 = n, count = n * n, c = 1;
            bool inRow = true, inCol = false, inRevRow = false, inRevCol = false;
            int inRowCount = 0, inColCount = 0, inRevRowCount = 0, inRevColCount = 0;

            while (c != count + 1)
            {
                result[i][j] = c;
                if (inRow)
                {
                    if (j == n2 - 1 - inColCount)
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

                c++;
            }

            return result;
        }
    }
}

