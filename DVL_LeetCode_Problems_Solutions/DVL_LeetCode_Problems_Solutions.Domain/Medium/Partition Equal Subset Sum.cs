using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Partition Equal Subset Sum (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool CanPartition(int[] nums)
        {
            int t = nums.Sum();
            bool[] din = new bool[t / 2 + 1];

            din[0] = true;

            if (t % 2 == 1)
                return false;

            foreach (var num in nums)
            {
                bool[] din2 = din.ToArray();
                for (int i = 0; i < din.Length; i++)
                    if (din[i] && i + num < din.Length)
                        din2[i + num] = true;
                din = din2;
            }

            return din[t/2];
        }
    }
}
