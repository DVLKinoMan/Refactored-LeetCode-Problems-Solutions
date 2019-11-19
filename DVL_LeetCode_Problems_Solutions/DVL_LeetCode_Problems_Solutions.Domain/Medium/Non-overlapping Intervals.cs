using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        ///  Non-overlapping Intervals (Not Mine)
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public static int EraseOverlapIntervals(int[][] intervals)
        {
            if (intervals.Length == 0)
                return 0;

            int count = 1;
            intervals = intervals.OrderBy(arr => arr[1]).ToArray();
            int end = intervals[0][1];
            for (int i = 1; i < intervals.Length; i++)
                if (intervals[i][0] >= end)
                {
                    end = intervals[i][1];
                    count++;
                }

            return intervals.Length - count;
        }
    }
}
