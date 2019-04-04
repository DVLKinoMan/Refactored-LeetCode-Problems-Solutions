using System;
using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Merge Intervals
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public static IList<Interval> Merge(IList<Interval> intervals)
        {
            var result = new List<Interval>();
            Interval lastInterval = null;

            foreach (var interval in intervals.OrderBy(i => i.start))
            {
                if (lastInterval == null)
                    lastInterval = interval;
                else if (lastInterval.end >= interval.start)
                    lastInterval.end = Math.Max(lastInterval.end, interval.end);
                else
                {
                    result.Add(lastInterval);
                    lastInterval = interval;
                }
            }

            if (lastInterval != null && (result.Count == 0 || result.Last() != lastInterval))
                result.Add(lastInterval);

            return result;
        }
    }
}
