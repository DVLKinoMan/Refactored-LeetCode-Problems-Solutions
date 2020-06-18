namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Number of Students Doing Homework at a Given Time (Mine)
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="queryTime"></param>
        /// <returns></returns>
        public static int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            int count = 0;
            for (int i = 0; i < startTime.Length; i++)
                if (startTime[i] <= queryTime && endTime[i] >= queryTime)
                    count++;

            return count;
        }
    }
}