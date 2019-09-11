using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain.Easy
{
    partial class ProblemSolver
    {
        public static IList<bool> PrefixesDivBy5(int[] A)
        {
            var str = new StringBuilder();
            bool[] answers = new bool[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                str.Append(A[i]);
                answers[i] = int.Parse(Convert.ToString(int.Parse(str.ToString()), 10)) % 5 == 0;
            }

            return answers;
        }
    }
}
