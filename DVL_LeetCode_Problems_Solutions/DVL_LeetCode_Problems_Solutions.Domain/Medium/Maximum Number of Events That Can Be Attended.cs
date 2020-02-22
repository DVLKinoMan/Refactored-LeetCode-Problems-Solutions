using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximum Number of Events That Can Be Attended (Not Mine and do not understanding solution)
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static int MaxEvents(int[][] events)
        {
            var visitedSet = new HashSet<int>(); 

            foreach (var arr in events.OrderBy(ev => ev[1]).ThenBy(ev => ev[0]))
            {
                int start = arr[0], end = arr[1];
                for (int j = start; j < end; j++)
                    if (visitedSet.Add(j))
                        break;
            }

            return visitedSet.Count;
        }
    }
}