using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
       /// <summary>
       /// Maximum XOR of Two Numbers in an Array (Not mine - Do not understand solution)
       /// </summary>
       /// <param name="nums"></param>
       /// <returns></returns>
        public static int FindMaximumXOR(int[] nums)
        {
            int max = 0, mask = 0;
            for (int i = 31; i >= 0; i--)
            {
                mask = mask | (1 << i);
                var set = new HashSet<int>();
                foreach (var num in nums)
                    set.Add(num & mask);
                int tmp = max | (1 << i);
                foreach (var prefix in set)
                    if (set.Contains(tmp ^ prefix))
                    {
                        max = tmp;
                        break;
                    }
            }

            return max;
        }
    }
}