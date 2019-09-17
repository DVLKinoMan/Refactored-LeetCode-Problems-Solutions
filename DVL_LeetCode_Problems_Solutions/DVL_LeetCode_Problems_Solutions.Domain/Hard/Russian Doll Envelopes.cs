using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static int MaxEnvelopes(int[][] envelopes)
        {
            envelopes.OrderBy(env => env[0])
        }
    }
}
