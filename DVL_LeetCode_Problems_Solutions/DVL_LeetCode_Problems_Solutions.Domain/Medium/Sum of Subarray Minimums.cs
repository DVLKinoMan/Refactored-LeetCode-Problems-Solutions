using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static int SumSubarrayMins(int[] A)
        {
            if (A.Length == 0)
                return 0;

            bool isOdd = A.Length % 2 == 1;
            int[] arr = new int[A.Length / 2 + (isOdd ? 1 : 0)];
            int result = 0;

            int j = 0;
            for (int i = 1; i < A.Length; i += 2, j++)
            {
                int k = A[i] + A[i - 1];
                arr[j] = k;
                result += k;
            }

            if (isOdd)
                arr[arr.Length - 1] = A[A.Length - 1];

            return result + SumSubarrayMins(arr);
        }
    }
}
