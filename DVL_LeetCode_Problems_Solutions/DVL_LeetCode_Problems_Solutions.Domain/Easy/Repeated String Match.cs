using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Repeated String Match (Not Working)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int RepeatedStringMatch(string A, string B)
        {
            int res = int.MaxValue;
            var indexes = A.Select((a, i) => (a, i)).Where(t => t.a == B[0]).Select(t => t.i);
            foreach (var index in indexes)
            {
                int aIndex = index, count = 1;
                bool can = true;
                for (int i = 0; i < B.Length; i++)
                {
                    if (A[aIndex] != B[i])
                    {
                        can = false;
                        break;
                    }

                    if (A.Length - 1 == aIndex)
                    {
                        aIndex = 0;
                        count++;
                    }
                    else aIndex++;
                }

                if (can)
                    res = Math.Min(res, count);
            }

            return res == int.MaxValue ? -1 : res;
        }
    }
}
