using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        //public static int modulo =(int) Math.Pow(10, 9) + 7;
        //public static int SumSubarrayMins(int[] A, int n = -1)
        //{
        //    if (n == -1)
        //        n = A.Length;
        //    if (n == 0)
        //        return 0;

        //    int result = A[0];

        //    for (int i = 1; i < n; i++)
        //    {
        //        A[i - 1] = Math.Min(A[i - 1], A[i]);
        //        result += A[i];
        //        result %= modulo;
        //    }

        //    return result + SumSubarrayMins(A, n - 1);
        //}

        /// <summary>
        /// Sum of Subarray Minimums (Not Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int SumSubarrayMins(int[] A)
        {
            int res = 0, n = A.Length, mod = (int) 1e9 + 7;
            int[] left = new int[n], right = new int[n];
            Stack<(int, int)> s1 = new Stack<(int, int)>(), s2 = new Stack<(int, int)>();
            for (int i = 0; i < n; ++i)
            {
                int count = 1;
                while (s1.Count != 0 && s1.Peek().Item1 > A[i])
                    count += s1.Pop().Item2;
                s1.Push((A[i], count));
                left[i] = count;
            }

            for (int i = n - 1; i >= 0; --i)
            {
                int count = 1;
                while (s2.Count != 0 && s2.Peek().Item1 >= A[i])
                    count += s2.Pop().Item2;
                s2.Push((A[i], count));
                right[i] = count;
            }

            for (int i = 0; i < n; ++i)
                res = (res + A[i] * left[i] * right[i]) % mod;
            return res;
        }
    }
}
