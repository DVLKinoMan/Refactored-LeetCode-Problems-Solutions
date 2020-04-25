using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Circle and Rectangle Overlapping (Not Mine)
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="x_center"></param>
        /// <param name="y_center"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        public static bool CheckOverlap(int radius, int x_center, int y_center, int x1, int y1, int x2, int y2)
        {
            int closestX = Clamp(x_center, x1, x2);
            int closestY = Clamp(y_center, y1, y2);

            int distanceX = x_center - closestX;
            int distanceY = y_center - closestY;

            return (distanceX * distanceX) + (distanceY * distanceY) <= radius * radius;

            int Clamp(int val, int min, int max) => Math.Max(min, Math.Min(max, val));
        }
    }
}