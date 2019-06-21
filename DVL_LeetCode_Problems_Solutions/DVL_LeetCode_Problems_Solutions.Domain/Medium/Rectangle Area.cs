using System;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Rectangle Area (Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <param name="D"></param>
        /// <param name="E"></param>
        /// <param name="F"></param>
        /// <param name="G"></param>
        /// <param name="H"></param>
        /// <returns></returns>
        public static int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H)
        {
            int firstArea = Math.Abs(D - B) * Math.Abs(C - A);
            int secondArea = Math.Abs(H - F) * Math.Abs(G - E);

            int xLen = 0;
            int yLen = 0;

            if (A >= E && A <= G)
                xLen = Math.Min(C, G) - A;
            else if (C >= E && C <= G)
                xLen = C - Math.Max(A, E);
            else if (E >= A && E <= C)
                xLen = Math.Min(C, G) - E;
            else if (G >= A && G <= C)
                xLen = G - Math.Max(A, E);

            if (B >= F && B <= H)
                yLen = Math.Min(D, H) - B;
            else if (D >= F && D <= H)
                yLen = D - Math.Max(B, F);
            else if (F >= B && F <= D)
                yLen = Math.Min(D, H) - F;
            else if (H >= B && H <= D)
                yLen = H - Math.Max(B, F);

            return firstArea + secondArea - (xLen * yLen);
        }
    }
}
