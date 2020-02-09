using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Check If N and Its Double Exist (Mine)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static bool CheckIfExist(int[] arr)
        {
            var set = new HashSet<int>();
            int zerosCount = 0;
            foreach (var num in arr)
            {
                if (num == 0)
                    zerosCount++;
                set.Add(num * 2);
            }
        
            return zerosCount > 1 || arr.Any(num => set.Contains(num) && num != 0);
        }
    }
}