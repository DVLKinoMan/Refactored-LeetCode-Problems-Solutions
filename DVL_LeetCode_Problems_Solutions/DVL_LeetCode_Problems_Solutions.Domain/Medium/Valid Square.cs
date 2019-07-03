using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Valid Square (Mine)
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        /// <param name="p4"></param>
        /// <returns></returns>
        public static bool ValidSquare(int[] p1, int[] p2, int[] p3, int[] p4)
        {
            double distanceFromp2 = ValidSquareHelperDistance(p1, p2), distanceFromp3 = ValidSquareHelperDistance(p1, p3), distanceFromp4 = ValidSquareHelperDistance(p1, p4);

            if (distanceFromp2 == 0 || distanceFromp3 == 0 || distanceFromp4 == 0)
                return false;

            if (distanceFromp2 == distanceFromp3)
            {
                if (ValidSquareHelperDistance(p3, p4) != distanceFromp2 || distanceFromp2 != ValidSquareHelperDistance(p2, p4))
                    return false;
                return distanceFromp4 == distanceFromp2 * 2;
            }
            else if (distanceFromp3 == distanceFromp4)
            {
                if (ValidSquareHelperDistance(p3, p2) != distanceFromp3 || distanceFromp3 != ValidSquareHelperDistance(p2, p4))
                    return false;
                return distanceFromp2 == distanceFromp3 * 2;
            }
            else if (distanceFromp2 == distanceFromp4)
            {
                if (ValidSquareHelperDistance(p3, p4) != distanceFromp2 || distanceFromp2 != ValidSquareHelperDistance(p3, p2))
                    return false;
                return distanceFromp3 == distanceFromp2 * 2;
            }

            return false;
        }

        public static double ValidSquareHelperDistance(int[] p1, int[] p2) =>
            Math.Pow(Math.Abs(p1[0] - p2[0]), 2) + Math.Pow(Math.Abs(p1[1] - p2[1]), 2);
    }
}
