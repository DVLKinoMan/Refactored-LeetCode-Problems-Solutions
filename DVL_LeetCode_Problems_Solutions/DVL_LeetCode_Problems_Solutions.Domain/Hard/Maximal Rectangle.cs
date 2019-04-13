namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static int MaximalRectangle(char[][] matrix)
        {
            if (matrix.Length == 0)
                return 0;

            int m = matrix.Length, n = matrix[0].Length;
            int[,] m2 = new int[m, n];
            for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
            {
                if (matrix[i][j] == '1')
                {
                    int count = 0;
                    while (j < n && matrix[i][j] == '1')
                    {
                        count++;
                        m2[i, j] = count;
                        j++;
                    }
                }
            }

            int max = 0;
            for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                if (m2[i, j] != 0)
                {
                    int i2 = i;
                    int min = m2[i,j];
                    i++;
                    while (i < m && m2[i, j] != 0)
                    {
                        if (m2[i, j] < min)
                            min = m2[i, j];
                        i++;
                    }

                    int potMax = (i - i2) * min;
                    if (potMax > max)
                        max = potMax;

                    i = i2;
                }

            return max;
        }
    }
}
