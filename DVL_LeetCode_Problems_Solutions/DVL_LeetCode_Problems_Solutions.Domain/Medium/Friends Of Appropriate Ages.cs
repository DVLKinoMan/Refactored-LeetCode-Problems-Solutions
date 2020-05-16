using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Friends Of Appropriate Ages (Mine)
        /// </summary>
        /// <param name="ages"></param>
        /// <returns></returns>
        public static int NumFriendRequests(int[] ages)
        {
            Array.Sort(ages);
            int lastIndex = 0, count = 0;
            for (int A = 1; A < ages.Length; A++)
            for (int B = lastIndex; B < A; B++)
            {
                if (ages[B] > 0.5 * ages[A] + 7)
                {
                    count += A - B;
                    int j = A - 1;
                    while (j >= 0 && ages[j--] == ages[A])
                        count++;
                    break;
                }

                lastIndex++;
            }

            return count;
        }
    }
}