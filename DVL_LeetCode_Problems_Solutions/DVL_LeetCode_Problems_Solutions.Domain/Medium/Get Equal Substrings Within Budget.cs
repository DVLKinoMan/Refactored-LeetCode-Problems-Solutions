using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static int EqualSubstring(string s, string t, int maxCost)
        {
            int[] costs = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
                costs[i] = Math.Abs(s[i] - t[i]);

        }
    }
}
