using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Sort Array By Parity (Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int[] SortArrayByParity(int[] A)
        {
            return A.Where(num => num % 2 == 0).Concat(A.Where(num => num % 2 == 1)).ToArray();
        }
    }
}
