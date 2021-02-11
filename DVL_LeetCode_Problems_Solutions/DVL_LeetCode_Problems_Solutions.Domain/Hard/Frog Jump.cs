using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Frog Jump (Mine)
        /// </summary>
        /// <param name="stones"></param>
        /// <returns></returns>
        public static bool CanCross(int[] stones)
        {
            var dict = new Dictionary<(int, int), bool>();
            return Can(0);

            bool Can(int index, int k = 0)
            {
                if (dict.ContainsKey((index, k)))
                    return dict[(index, k)];
                if (index == stones.Length - 1)
                    return true;
                if (index >= stones.Length)
                    return false;

                int i = index,
                    jump = stones[i] - stones[index];
                while (i < stones.Length && jump <= k + 1)
                {
                    jump = stones[i] - stones[index];
                    if (jump > 0 && (jump == k || jump == k - 1 || jump == k + 1))
                        if (Can(i, jump))
                            return dict[(index, k)] = true;
                    i++;
                }

                return dict[(index, k)] = false;
            }
        }
    }
}
