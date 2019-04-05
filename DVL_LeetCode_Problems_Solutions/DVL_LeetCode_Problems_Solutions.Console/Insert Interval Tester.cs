using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;

using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LeetCode_Problems_Solutions.Console
{
    partial class Tester
    {
        public static void InsertIntervalTester(List<Interval> list, Interval newInterval)
        {
            Insert(list.ToArray(), newInterval);
        }
    }
}
