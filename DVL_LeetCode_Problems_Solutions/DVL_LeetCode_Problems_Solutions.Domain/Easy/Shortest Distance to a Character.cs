using System;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain.Easy
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Shortest Distance to a Character (Mine)
        /// </summary>
        /// <param name="S"></param>
        /// <param name="C"></param>
        /// <returns></returns>
        public static int[] ShortestToChar(string S, char C)
        {
            int[] answers = new int[S.Length];
            var list = S.Select((s, i) => i).Where(i => S[i] == C).ToList();

            int index = 0;
            for (int i = 0; i < S.Length; i++)
            {
                int diff1 = Math.Abs(i - list[index]);
                int diff2 = Math.Abs(index + 1 < list.Count ? i - list[index + 1] : int.MaxValue);
                if (diff1 < diff2)
                    answers[i] = diff1;
                else
                {
                    answers[i] = diff2;
                    index++;
                }
            }

            return answers;
        }
    }
}
