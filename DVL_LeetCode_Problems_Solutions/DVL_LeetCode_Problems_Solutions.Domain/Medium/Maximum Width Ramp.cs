using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximum Width Ramp (Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int MaxWidthRamp(int[] A)
        {
            var sortedIndexes = A.Select((a, i) => (a, i)).OrderBy(t => t.a).Select(t => t.i);

            int prevMin = int.MaxValue, maxWidth = 0;
            foreach (var index in sortedIndexes)
            {
                if (index - prevMin > maxWidth)
                    maxWidth = index - prevMin;
                if (prevMin > index)
                    prevMin = index;
            }

            return maxWidth;
        }
    }
}
