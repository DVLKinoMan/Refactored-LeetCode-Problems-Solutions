using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximum Score After Splitting a String (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int MaxScore(string s) 
        {
            int[] onesCount = new int[s.Length];
            int[] zerosCount = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                if (i != 0)
                {
                    zerosCount[i] += zerosCount[i - 1];
                    onesCount[s.Length - i - 1] += onesCount[s.Length - i];
                }
                if (s[i] == '0')
                    zerosCount[i]++;
                if (s[s.Length - i - 1] == '1')
                    onesCount[s.Length - i - 1]++;
            }

            int maxScore = 0;
            for (int i = 0; i < s.Length - 1; i++)
                maxScore = Math.Max(maxScore, zerosCount[i] + onesCount[i + 1]);

            return maxScore;
        }
    }
}