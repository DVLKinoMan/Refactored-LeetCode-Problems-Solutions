using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static int max = (int)Math.Pow(10, 9) + 7;

        /// <summary>
        /// Knight Dialer (Not Mine)
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static int KnightDialer(int N)
        {
            var arr = new long[N][,];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = new long[4, 5];

            long s = 0;
            for (int i = 0; i < 4; i++)
            for (int j = 0; j < 3; j++)
                s = (s + KnightDialerHelper(arr, i, j, N)) % max;

            return (int) s;
        }

        private static long KnightDialerHelper(long[][,] M, int i, int j, int n)
        {
            if (i < 0 || j < 0 || i >= 4 || j >= 3 || (i == 0 && j == 0) || (i == 0 && j == 2))
                return 0;
            if (n == 1)
                return 1;

            if (M[n][i, j] > 0)
                return M[n][i, j];

            M[n][i, j] = KnightDialerHelper(M, i - 1, j - 2, n - 1) % max +
                         KnightDialerHelper(M, i - 2, j - 1, n - 1) % max +
                         KnightDialerHelper(M, i - 2, j + 1, n - 1) % max +
                         KnightDialerHelper(M, i - 1, j + 2, n - 1) % max +
                         KnightDialerHelper(M, i + 1, j + 2, n - 1) % max +
                         KnightDialerHelper(M, i + 2, j + 1, n - 1) % max +
                         KnightDialerHelper(M, i + 2, j - 1, n - 1) % max +
                         KnightDialerHelper(M, i + 1, j - 2, n - 1) % max; 
            return M[n][i, j];
        }
    }
}
