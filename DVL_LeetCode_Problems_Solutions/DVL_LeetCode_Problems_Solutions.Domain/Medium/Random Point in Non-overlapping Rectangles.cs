using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        private static Dictionary<int, int> map;
        private static int[][] arrays;
        private static int sum;
        private static Random rnd = new Random();

        public Solution(int[][] rects)
        {
            arrays = rects;
            map = new Dictionary<int, int>();
            sum = 0;

            for (int i = 0; i < rects.Length; i++)
            {
                int[] rect = rects[i];

                // the right part means the number of points can be picked in this rectangle
                sum += (rect[2] - rect[0] + 1) * (rect[3] - rect[1] + 1);

                map.Add(sum, i);
            }
        }

        public static int[] pick()
        {
            // nextInt(sum) returns a num in [0, sum -1]. After added by 1, it becomes [1, sum]
            int c = map.FirstOrDefault(i=>i.Value>rnd.Next(sum) + 1).Key;

            return pickInRect(arrays[map[c]]);
        }

        private static int[] pickInRect(int[] rect)
        {
            int left = rect[0], right = rect[2], bot = rect[1], top = rect[3];

            return new int[] { left + rnd.Next(right - left + 1), bot + rnd.Next(top - bot + 1) };
        }
    }
}
