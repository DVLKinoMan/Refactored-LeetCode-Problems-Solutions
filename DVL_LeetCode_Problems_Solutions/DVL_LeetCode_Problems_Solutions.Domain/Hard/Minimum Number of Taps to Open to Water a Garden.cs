using System;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Minimum Number of Taps to Open to Water a Garden (Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="ranges"></param>
        /// <returns></returns>
        public static int MinTaps(int n, int[] ranges)
        {
            var intervals = new (int x, int y)[ranges.Length];
            for (int i = 0; i < ranges.Length; i++)
                intervals[i] = (i - ranges[i] < 0 ? 0 : i - ranges[i],
                    i + ranges[i] > n ? n : i + ranges[i]);

            intervals = intervals.OrderBy(interval => interval.x).ToArray();
            var prevInterval = intervals[0];
            int count = 1;
            for (int i = 1; i < intervals.Length; i++)
            {
                var currInterval = intervals[i];
                if (currInterval.x == prevInterval.x)
                    prevInterval = currInterval.y > prevInterval.y ? currInterval : prevInterval;
                else if (currInterval.y > prevInterval.y)
                {
                    if (currInterval.x > prevInterval.y)
                        return -1;
                    else if (currInterval.x <= prevInterval.x)
                        prevInterval = (prevInterval.x, currInterval.y);
                    else
                    {
                        count++;
                        prevInterval = (Math.Max(prevInterval.y, currInterval.x), currInterval.y);
                    }
                }
            }

            return count;
        }
    }
}
