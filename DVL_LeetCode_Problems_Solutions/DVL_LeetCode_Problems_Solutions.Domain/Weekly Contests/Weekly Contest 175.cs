using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Check If N and Its Double Exist (Did not work)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static bool CheckIfExist(int[] arr)
        {
            var set = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
                set.Add(arr[i] * 2);

            for (int i = 0; i < arr.Length; i++)
                if (set.Contains(arr[i]))
                    return true;

            return false;
        }
    }
}