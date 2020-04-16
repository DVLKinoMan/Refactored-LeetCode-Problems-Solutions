using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Count Largest Group (Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int CountLargestGroup(int n)
        {
            var list = Enumerable.Range(1, n)
                .GroupBy(SumOfDigits)
                .ToList();
            int m = list.Max(gr => gr.Count());
            return list.Count(gr => gr.Count() == m);
            
            int SumOfDigits(int k)
            {
                int num = 0;
                while (k != 0)
                {
                    num += k % 10;
                    k /= 10;
                }

                return num;
            }
        }
    }
}