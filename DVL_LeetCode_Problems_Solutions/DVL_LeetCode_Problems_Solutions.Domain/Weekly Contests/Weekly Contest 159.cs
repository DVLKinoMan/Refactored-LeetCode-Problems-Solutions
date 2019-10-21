using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Check If It Is a Straight Line (Mine)
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public static bool CheckStraightLine(int[][] coordinates)
        {
            int x1 = coordinates[0][0], y1 = coordinates[0][1], x2 = coordinates[1][0], y2 = coordinates[1][1];
            double k = (y1 - y2) / (double) (x1 - x2);
            double b = y1 - k * x1;
            for (int i = 2; i < coordinates.Length; i++)
            {
                int x = coordinates[i][0], y = coordinates[i][1];
                if (y != k * x + b)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Remove Sub-Folders from the Filesystem (Mine)
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        public static IList<string> RemoveSubfolders(string[] folder)
        {
            var dict = new HashSet<string>();
            var res = new List<string>();
            foreach (var fld in folder.OrderBy(f=>f.Count(ch=>ch=='/')))
            {
                var builder =new StringBuilder();
                bool isValid = true;
                for (int i = 1; i < fld.Length; i++)
                {
                    if (fld[i] == '/' && dict.Contains(builder.ToString()))
                    {
                        isValid = false;
                        break;
                    }
                    else builder.Append(fld[i]);
                }

                if(!isValid)
                    continue;

                if (dict.Add(builder.ToString()))
                    res.Add(fld);
            }

            return res;
        }

        /// <summary>
        /// Maximum Profit in Job Scheduling (Not Mine)
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="profit"></param>
        /// <returns></returns>
        public static int JobScheduling(int[] startTime, int[] endTime, int[] profit)
        {
            var list = new List<(int st, int end, int prof)>();
            for (int i = 0; i < startTime.Length; i++)
                list.Add((startTime[i], endTime[i], profit[i]));
            list = list.OrderBy(l => l.end).ToList();

            var dpEndTime = new List<int>();
            var dpProfit = new List<int>();
            // init value to avoid IndexOutBoundExp
            dpEndTime.Add(0);
            dpProfit.Add(0);
            foreach (var item in list)
            {
                // find previous endTime index
                int prevIdx = dpEndTime.BinarySearch(item.st + 1);
                if (prevIdx < 0)
                    prevIdx = -prevIdx - 1;
                prevIdx--;
                int currProfit = dpProfit[prevIdx] + item.prof, maxProfit = dpProfit[dpProfit.Count - 1];
                if (currProfit > maxProfit)
                {
                    dpProfit.Add(currProfit);
                    dpEndTime.Add(item.end);
                }
            }

            return dpProfit[dpProfit.Count - 1];
        }
    }
}
