using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Perfect Rectangle (Not Mine)
        /// </summary>
        /// <param name="rectangles"></param>
        /// <returns></returns>
        public static bool IsRectangleCover(int[][] rectangles)
        {
            if (rectangles.Length == 0 || rectangles[0].Length == 0)
                return false;

            int min_X = int.MaxValue,
                max_x = int.MinValue,
                min_Y = int.MaxValue,
                max_Y = int.MinValue;

            var set = new HashSet<string>();
            int area = 0;

            foreach (var rect in rectangles)
            {
                min_X = Math.Min(rect[0], min_X);
                min_Y = Math.Min(rect[1], min_Y);
                max_x = Math.Max(rect[2], max_x);
                max_Y = Math.Max(rect[3], max_Y);

                area += (rect[2] - rect[0]) * (rect[3] - rect[1]);

                string s1 = rect[0] + " " + rect[1];
                string s2 = rect[0] + " " + rect[3];
                string s3 = rect[2] + " " + rect[3];
                string s4 = rect[2] + " " + rect[1];

                if (!set.Add(s1)) set.Remove(s1);
                if (!set.Add(s2)) set.Remove(s2);
                if (!set.Add(s3)) set.Remove(s3);
                if (!set.Add(s4)) set.Remove(s4);
            }

            if (!set.Contains(min_X + " " + min_Y) || 
                !set.Contains(min_X + " " + max_Y) || 
                !set.Contains(max_x + " " + min_Y) || 
                !set.Contains(max_x + " " + max_Y) || 
                set.Count != 4) 
                return false;

            return area == (max_x - min_X) * (max_Y - min_Y);
        }
    }
}
