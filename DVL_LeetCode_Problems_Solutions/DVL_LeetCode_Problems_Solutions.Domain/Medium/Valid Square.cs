using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static bool ValidSquare(int[] p1, int[] p2, int[] p3, int[] p4)
        {

        }

        public static double DistanceBettweenTwoPoints(int[] p1, int[] p2) =>
            Math.Sqrt(Math.Pow(Math.Abs(p1[0] - p2[0]), 2) + Math.Pow(Math.Abs(p1[1] - p2[1]), 2));
    }
}
