using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Binary Gap (Mine)
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static int BinaryGap(int N)
        {
            string str = System.Convert.ToString(N, 2);
            int prevIndex = -1, max = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '1')
                {
                    if (prevIndex != -1)
                    {
                        max = Math.Max(max, i - prevIndex);
                    }

                    prevIndex = i;
                }
            }

            return max;
        }
    }
}
