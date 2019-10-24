namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Valid Mountain Array (Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static bool ValidMountainArray(int[] A)
        {
            if (A.Length < 3)
                return false;

            if (A[1] < A[0])
                return false;

            bool goingUp = true;
            for (int i = 2; i < A.Length; i++)
            {
                if (A[i] < A[i - 1] && goingUp)
                    goingUp = false;
                else if (A[i] > A[i - 1] && !goingUp)
                    return false;
                else if (A[i] == A[i - 1])
                    return false;
            }

            return !goingUp;
        }
    }
}
