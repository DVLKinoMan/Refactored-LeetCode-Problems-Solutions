using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Build an Array With Stack Operations (Mine)
        /// </summary>
        /// <param name="target"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static IList<string> BuildArray(int[] target, int n)
        {
            var result = new List<string>();
            int i = 0, num = 1;
            while (i != target.Length)
            {
                result.Add("Push");
                if (target[i] == num)
                    i++;
                else result.Add("Pop");
                num++;
            }

            return result;
        }
    }
}