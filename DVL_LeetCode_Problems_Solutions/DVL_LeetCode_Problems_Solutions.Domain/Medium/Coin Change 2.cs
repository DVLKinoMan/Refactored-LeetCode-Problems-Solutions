using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
   partial class ProblemSolver
    {
        /// <summary>
        /// Coin Change 2 (Not working)
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="coins"></param>
        /// <returns></returns>
        public static int Change(int amount, int[] coins)
        {
//            5
//[1, 2, 5]
//4 3 2 1 0
            var dic = new Dictionary<int, int>();
            int count = 0;

            for (int i = 0; i < coins.Length; i++)
                if (coins[i] <= amount)
                {
                    int k = 1;
                    while (true)
                    {
                        int val = coins[i] * k;
                        if (amount - val < 0)
                            break;
                        if (dic.ContainsKey(val))
                            count += dic[val];
                        else if (dic.ContainsKey(amount - val))
                            dic[amount - val]++;
                        else
                            dic.Add(amount - val, 1);
                        k++;
                    }
                }

            return count;
        }
    }
}
