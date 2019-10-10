using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Longest Mountain in Array (Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int LongestMountain(int[] A)
        {
            int maxCount = 0, currCount = 0;
            bool isMountain = false;
            for (int i = 1; i < A.Length; i++)
            {
                if (currCount > 0)
                {
                    if (A[i] < A[i - 1])
                    {
                        currCount++;
                        isMountain = true;
                    }
                    else if (A[i] > A[i - 1])
                    {
                        if (isMountain)
                        {
                            maxCount = Math.Max(maxCount, currCount + 1);
                            isMountain = false;
                            currCount = 1;
                        }
                        else currCount++;
                    }
                    else
                    {
                        if (isMountain)
                        {
                            maxCount = Math.Max(maxCount, currCount + 1);
                            isMountain = false;
                        }

                        currCount = 0;
                    }
                }
                else
                {
                    if (A[i] > A[i - 1])
                        currCount++;
                }
            }

            if (isMountain)
                maxCount = Math.Max(maxCount, currCount + 1);

            return maxCount;
        }
    }
}