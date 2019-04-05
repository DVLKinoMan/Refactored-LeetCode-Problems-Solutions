using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        ///// <summary>
        ///// Maybe Works When intervals is List, but when Array Not working
        ///// </summary>
        ///// <param name="intervals"></param>
        ///// <param name="newInterval"></param>
        ///// <returns></returns>
        //public static IList<Interval> Insert(IList<Interval> intervals, Interval newInterval)
        //{
        //    int startIndex = -1, endIndex = -1, inPosition = -1;
        //    for (int i = 0; i < intervals.Count; i++)
        //    {
        //        if (startIndex == -1)
        //        {
        //            if (intervals[i].start <= newInterval.start && intervals[i].end <= newInterval.start)
        //                startIndex = i;
        //            else if (intervals[i].start > newInterval.start)
        //            {
        //                inPosition = i;
        //                break;
        //            }
        //        }
        //        else
        //        {
        //            if (newInterval.end < intervals[i].start)
        //            {
        //                endIndex = i - 1;
        //                break;
        //            }

        //            if (newInterval.end < intervals[i].end)
        //            {
        //                endIndex = i;
        //                break;
        //            }
        //        }
        //    }

        //    if (inPosition != -1)
        //        intervals.Insert(inPosition, newInterval);
        //    else if (startIndex == -1)
        //        intervals.Add(newInterval);
        //    else
        //    {
        //        int first = intervals[startIndex].start,
        //            end = endIndex == -1 ? newInterval.end : Math.Max(newInterval.end, intervals[endIndex].end);
        //        for (int i = startIndex; i <= (endIndex == -1 ? intervals.Count - 1 : endIndex); i++)
        //            intervals.RemoveAt(startIndex);
        //        intervals.Insert(startIndex, new Interval(first, end));
        //    }

        //    return intervals;
        //}

        /// <summary>
        /// Insert Interval
        /// </summary>
        /// <param name="intervals"></param>
        /// <param name="newInterval"></param>
        /// <returns></returns>
        public static IList<Interval> Insert(IList<Interval> intervals, Interval newInterval)
        {
            var result = new List<Interval>();

            int i = 0, start = -1;
            bool inserted = false;
            while (i < intervals.Count)
            {
                if (inserted)
                    result.Add(intervals[i]);
                else if (start == -1)
                {
                    if (intervals[i].start > newInterval.start)
                    {
                        start = newInterval.start;
                        continue;
                    }

                    if (intervals[i].start <= newInterval.start && intervals[i].end >= newInterval.start)
                    {
                        start = intervals[i].start;
                        continue;
                    }
                    else result.Add(intervals[i]);
                }
                else
                {
                    if (newInterval.end < intervals[i].start)
                    {
                        result.Add(new Interval(start, newInterval.end));
                        inserted = true;
                        continue;
                    }

                    if (newInterval.end < intervals[i].end)
                    {
                        result.Add(new Interval(start, intervals[i].end));
                        inserted = true;
                    }
                }

                i++;
            }

            if (start == -1 && !inserted)
                result.Add(newInterval);
            else if (!inserted)
                result.Add(new Interval(start, newInterval.end));

            return result;
        }
    }
}
