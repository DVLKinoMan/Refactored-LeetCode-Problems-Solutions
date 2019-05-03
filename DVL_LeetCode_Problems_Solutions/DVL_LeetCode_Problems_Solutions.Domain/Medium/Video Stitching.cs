using System;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        ///// <summary>
        ///// Video Stitching (Not Works)
        ///// </summary>
        ///// <param name="clips"></param>
        ///// <param name="T"></param>
        ///// <returns></returns>
        //public static int VideoStitching(int[][] clips, int T)
        //{
        //    clips = clips.OrderBy(cl => cl[0]).ToArray();
        //    int count = 0, current = 0;
        //    for (int i = 0; i < clips.Length; i++)
        //    {
        //        if (clips[i][0] > current)
        //            return -1;
        //        else
        //        {
        //            if (clips[i][0] <= current)
        //            {
        //                int max = current, j = i;
        //                while (i < clips.Length && clips[i][0] <= current)
        //                {
        //                    if (clips[i][1] > max)
        //                        max = clips[i][1];
        //                    i++;
        //                }

        //                count++;

        //                if (max >= T)
        //                    return count;

        //                if (j != i)
        //                    i--;
        //                current = max + 1;
        //            }
        //        }
        //    }

        //    return -1;
        //}

        /// <summary>
        /// Video Stitching (Not Mine)
        /// </summary>
        /// <param name="clips"></param>
        /// <param name="T"></param>
        /// <returns></returns>
        public static int VideoStitching(int[][] clips, int T)
        {
            int res = 0;
            clips = clips.OrderBy(cl => cl[0]).ToArray();
            for (int i = 0, st = 0, end = 0; st < T; st = end, ++res)
            {
                for (; i < clips.Length && clips[i][0] <= st; ++i)
                    end = Math.Max(end, clips[i][1]);
                if (st == end)
                    return -1;
            }
            return res;
        }
    }
}
