namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Diagonal Traverse (Not Mine)
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static int[] FindDiagonalOrder(int[][] matrix)
        {
            if (matrix.Length == 0)
                return new int[0];
            int r = 0, c = 0, m = matrix.Length, n = matrix[0].Length;
            int[] arr = new int[m * n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = matrix[r][c];
                if ((r + c) % 2 == 0)
                {
                    if (c == n - 1)
                        r++; 
                    else if (r == 0)
                        c++;
                    else
                    {
                        r--;
                        c++;
                    }
                }
                else
                { 
                    if (r == m - 1)
                        c++; 
                    else if (c == 0)
                        r++;
                    else
                    {
                        r++;
                        c--;
                    }
                }
            }
            return arr;
        }
    }
}
