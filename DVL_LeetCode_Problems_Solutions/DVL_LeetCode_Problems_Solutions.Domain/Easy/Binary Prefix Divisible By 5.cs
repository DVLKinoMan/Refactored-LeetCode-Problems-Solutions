using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain.Easy
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Binary Prefix Divisible By 5 (Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static IList<bool> PrefixesDivBy5(int[] A)
        {
            bool[] answers = new bool[A.Length];

            int mod = 0;
            for (int i = 0; i < A.Length; i++)
            {
                mod = (mod * 2 + A[i]) % 5;
                answers[i] = mod == 0;
            }

            return answers;
        }
    }
}
