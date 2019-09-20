namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Largest Time for Given Digits (Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static string LargestTimeFromDigits(int[] A)
        {
            bool IsValid(int h1, int h2, int m1, int m2)
            {
                if (h1 > 2)
                    return false;
                if (h1 == 2 && h2 > 4)
                    return false;
                if (m1 >= 6)
                    return false;
                if (h1 == 2 && h2 == 4)
                    return false;
                if (m1 == 6 && m2 > 0)
                    return false;
                return true;
            }

            string res = string.Empty;
            int max = -1;
            for (int h1 = 0; h1 < A.Length; h1++)
                for (int h2 = 0; h2 < A.Length; h2++)
                    if (h2 != h1)
                        for (int m1 = 0; m1 < A.Length; m1++)
                            if (m1 != h2 && m1 != h1)
                                for (int m2 = 0; m2 < A.Length; m2++)
                                    if (m2 != m1 && m2 != h2 && m2 != h1)
                                        if (IsValid(A[h1], A[h2], A[m1], A[m2]))
                                        {
                                            int k = A[h1] * 1000 + A[h2] * 100 + A[m1] * 10 + A[m2];
                                            if (k > max)
                                            {
                                                res = $"{A[h1]}{A[h2]}:{A[m1]}{A[m2]}";
                                                max = k;
                                            }
                                        }

            return res;
        }
    }
}
