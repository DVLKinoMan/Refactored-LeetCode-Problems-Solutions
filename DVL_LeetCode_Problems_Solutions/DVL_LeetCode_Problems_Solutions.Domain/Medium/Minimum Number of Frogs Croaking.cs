using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Minimum Number of Frogs Croaking (Mine)
        /// </summary>
        /// <param name="croakOfFrogs"></param>
        /// <returns></returns>
        public static int MinNumberOfFrogs(string croakOfFrogs)
        {
            var charIndexes = new Dictionary<char, int>() {{'c', 0}, {'r', 1}, {'o', 2}, {'a', 3}, {'k', 4}};
            var frogsCountOnIndexes = new Dictionary<int, int>() {{0, 0}, {1, 0}, {2, 0}, {3, 0}, {4, 0},};
            foreach (var ch in croakOfFrogs)
            {
                int index = charIndexes[ch];
                if (frogsCountOnIndexes[index] > 0)
                {
                    frogsCountOnIndexes[index]--;
                    frogsCountOnIndexes[index + 1 == 5 ? 0 : index + 1]++;
                }
                else
                {
                    if (ch != 'c')
                        return -1;
                    frogsCountOnIndexes[1]++;
                }
            }

            for (int i = 1; i < 5; i++)
                if (frogsCountOnIndexes[i] != 0)
                    return -1;

            return frogsCountOnIndexes[0];
        }
    }
}