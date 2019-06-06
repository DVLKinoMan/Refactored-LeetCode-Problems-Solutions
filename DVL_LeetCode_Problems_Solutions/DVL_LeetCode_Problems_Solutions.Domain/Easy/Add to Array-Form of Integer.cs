using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain.Easy
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Add to Array-Form of Integer (Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public static IList<int> AddToArrayForm(int[] A, int K)
        {
            var list = new List<int>();
            var secondArray = K.ToString().Select(n => n - 48).ToArray();
            int carry = 0;
            for (int i = 1; i <= A.Length || i <= secondArray.Length || carry > 0; i++)
            {
                int index1 = A.Length - i;
                int index2 = secondArray.Length - i;
                int sum = index1 >= 0 ? A[index1] : 0 + index2 >= 0 ? secondArray[index2] : 0 + carry;
                list.Add(sum % 10);
                carry = sum / 10;
            }

            list.Reverse();
            return list.ToArray();
        }
    }
}
