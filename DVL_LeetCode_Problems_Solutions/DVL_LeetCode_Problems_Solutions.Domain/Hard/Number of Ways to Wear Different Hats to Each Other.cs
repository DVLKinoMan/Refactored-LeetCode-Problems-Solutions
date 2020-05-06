using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Number of Ways to Wear Different Hats to Each Other (Not Mine)
        /// </summary>
        /// <param name="hats"></param>
        /// <returns></returns>
        public static int NumberWays(IList<IList<int>> hats)
        {
            int MOD = ((int) 1E9) + 7;
            int peopleCount = hats.Count;

            int[] current = new int[1 << peopleCount];
            int[] next = new int[1 << peopleCount];
            next[0] = 1;
            current[0] = 1;
            
            for (int i = 1; i <= 40; i++)
            {
                for (int person = 0; person < peopleCount; person++)
                {
                    bool isHatAvailable = false;
                    for (int j = 0; j < hats[person].Count; j++)
                        if (hats[person][j] == i)
                        {
                            isHatAvailable = true;
                            break;
                        }

                    if (isHatAvailable)
                    {
                        int personMask = 1 << person;
                        for (int j = 0; j < next.Length; j++)
                            if ((j & personMask) == 0)
                                next[j | personMask] = (next[j | personMask] + current[j]) % MOD;
                    }
                }

                for (int j = 0; j < current.Length; j++)
                    current[j] = next[j];
            }

            return current[current.Length - 1];
        }
    }
}