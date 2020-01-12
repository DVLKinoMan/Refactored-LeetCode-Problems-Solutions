using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Convert Integer to the Sum of Two No-Zero Integers (Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] GetNoZeroIntegers(int n)
        {
            for (int i = 1; i < n; i++)
                if (NotContainsZero(i))
                {
                    int j = n - i;
                    if (NotContainsZero(j))
                        return new int[] {i, j};
                }

            return new int[0];

            bool NotContainsZero(int k) => !k.ToString().Contains('0');
        }
    }
}
