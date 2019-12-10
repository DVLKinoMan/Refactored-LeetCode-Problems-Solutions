using System;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Repeated String Match (Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int RepeatedStringMatch(string A, string B)
        {
            int count = (int)Math.Ceiling((double) B.Length / A.Length);
            string str = string.Concat(Enumerable.Repeat(A, count));
            return str.Contains(B) ? count : (str + A).Contains(B) ? count + 1 : -1;
        }
    }
}
