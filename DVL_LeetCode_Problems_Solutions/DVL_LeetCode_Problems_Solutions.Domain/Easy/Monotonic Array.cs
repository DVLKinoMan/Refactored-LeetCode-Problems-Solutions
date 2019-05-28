namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Monotonic Array (Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static bool IsMonotonic(int[] A)
        {
            if (A.Length <= 1)
                return true;

            bool increase = false;
            int i = 1;
            while (i < A.Length && A[i] == A[i - 1])
                i++;

            if (i == A.Length)
                return true;

            if (A[i] > A[i - 1])
                increase = true;

            for (; i < A.Length; i++)
                if ((increase && A[i] < A[i - 1]) || (!increase && A[i] > A[i - 1]))
                    return false;

            return true;
        }
    }
}
