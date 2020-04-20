using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Find the Minimum Number of Fibonacci Numbers Whose Sum Is K (Mine)
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int FindMinFibonacciNumbers(int k) 
        {
            var fibonacciNums = new List<int>(){1,1};
            var set = new HashSet<int>() {1};
            int index = 1;
            while (fibonacciNums[index] < k)
            {
                fibonacciNums.Add(fibonacciNums[index - 1] + fibonacciNums[index++]);
                set.Add(fibonacciNums[index]);
            }

            return Find(k);

            int Find(int c)
            {
                if (set.Contains(c))
                    return 1;

                int ind = 1;
                while (fibonacciNums[ind] < c)
                    ind++;

                return Find(c - fibonacciNums[ind - 1]) + 1;
            }
        }
    }
}