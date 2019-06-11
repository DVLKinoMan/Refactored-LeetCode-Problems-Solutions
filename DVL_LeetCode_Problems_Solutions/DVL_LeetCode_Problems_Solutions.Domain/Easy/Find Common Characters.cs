using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Find Common Characters (Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static IList<string> CommonChars(string[] A)
        {
            var intersection = A[0].ToCharArray().ToList();
            for (int i = 1; i < A.Length; i++)
            for (int k = 0; k < intersection.Count; k++)
            {
                int index = A[i].IndexOf(intersection[k]);
                if (index >= 0)
                    A[i] = A[i].Remove(index, 1);
                else
                {
                    intersection.RemoveAt(k);
                    k--;
                }
            }

            return intersection.Select(ch => ch.ToString()).ToList();
        }
    }
}
