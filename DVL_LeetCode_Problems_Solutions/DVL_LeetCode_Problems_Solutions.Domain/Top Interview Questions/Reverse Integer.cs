using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static int Reverse2(int x)
        {
            if (x == int.MinValue)
                return 0;
            int x2 = Math.Abs(x);
            int overflow = int.MaxValue / 10, res = 0;
            while (x2 != 0)
            {
                if (res > overflow)
                    return 0;
                res *= 10;
                res += (x2 % 10);
                x2 /= 10;
            }

            return x < 0 ? -res : res;
        }
    }
}