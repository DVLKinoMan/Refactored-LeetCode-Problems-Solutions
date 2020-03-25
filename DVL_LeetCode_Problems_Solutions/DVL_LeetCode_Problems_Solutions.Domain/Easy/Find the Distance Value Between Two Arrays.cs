using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Find the Distance Value Between Two Arrays (Mine)
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {
            int count = 0;
            foreach (var num1 in arr1)
            {
                foreach (var num2 in arr2)
                    if (Math.Abs(num1 - num2) <= d)
                    {
                        count--;
                        break;
                    }

                count++;
            }

            return count;
        }
    }
}