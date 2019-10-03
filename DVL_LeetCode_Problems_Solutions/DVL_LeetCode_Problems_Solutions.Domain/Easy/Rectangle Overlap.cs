using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Rectangle Overlap (Not working)
        /// </summary>
        /// <param name="rec1"></param>
        /// <param name="rec2"></param>
        /// <returns></returns>
        public static bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            var firstRecCoos = new List<(int x, int y)>();
            firstRecCoos.Add((rec1[0], rec1[1]));
            firstRecCoos.Add((rec1[2], rec1[3]));
            firstRecCoos.Add((rec1[0], rec1[3]));
            firstRecCoos.Add((rec1[2], rec1[1]));

            var secondRecCoos = new List<(int x, int y)>();
            secondRecCoos.Add((rec2[0], rec2[1]));
            secondRecCoos.Add((rec2[2], rec2[3]));
            secondRecCoos.Add((rec2[0], rec2[3]));
            secondRecCoos.Add((rec2[2], rec2[1]));

            foreach (var coo in firstRecCoos)
                if (coo.x > secondRecCoos[0].Item1 && coo.x < secondRecCoos[1].Item1 && coo.y > secondRecCoos[0].Item2 && coo.y < secondRecCoos[1].Item2)
                    return true;

            foreach (var coo in secondRecCoos)
                if (coo.x > firstRecCoos[0].Item1 && coo.x < firstRecCoos[1].Item1 && coo.y > firstRecCoos[0].Item2 && coo.y < firstRecCoos[1].Item2)
                    return true;

            return false;
        }
    }
}
