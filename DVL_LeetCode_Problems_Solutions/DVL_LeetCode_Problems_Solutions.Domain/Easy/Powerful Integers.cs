using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Powerful Integers (Almost Mine)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="bound"></param>
        /// <returns></returns>
        public static IList<int> PowerfulIntegers(int x, int y, int bound)
        {
            var res = new HashSet<int>();

            for (int i = 1; i < bound; i*=x)
            {
                for (int j = 1; i + j <= bound; j*=y)
                {
                    res.Add(i+j);
                    if (y == 1)
                        break;
                }

                if (x == 1)
                    break;
            }

            return res.ToList();
        }
    }
}
