namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Peak Index in a Mountain Array (Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int PeakIndexInMountainArray(int[] A)
        {
            int i = 1;
            while (A[i] > A[i - 1])
                i++;

            return i - 1;
        }
    }
}
