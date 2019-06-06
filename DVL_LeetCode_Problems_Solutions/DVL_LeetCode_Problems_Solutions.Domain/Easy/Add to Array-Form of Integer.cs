using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain.Easy
{
    partial class ProblemSolver
    {
        public IList<int> AddToArrayForm(int[] A, int K)
        {
            var list = new List<int>();
            var arr = K.ToString().Select(i => (int) i - 48).ToArray();
            int carry = 0;
            for (int i = 1; i <= A.Length && i <= arr.Length; i++)
            {
                int num = A[A.Length - i] + arr[arr.Length - i] + carry;
                list.Add(num % 10);
                carry = num / 10;
            }

            if (carry != 0)
                list.Add(carry);

            list.Reverse();

            return list.ToArray();
        }
    }
}
