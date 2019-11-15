using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximum Swap (Mine)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int MaximumSwap(int num)
        {
            var str = num.ToString();
            var list = new List<(int num, int index)>();
            for (int i = 0; i < str.Length; i++)
                list.Add((str[i], i));

            list = list.OrderByDescending(l => l.num).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                var (n, ind) = list[i];
                if (str[i] == n)
                    continue;

                int k = i, max = num;;
                do
                {
                    var builder = new StringBuilder(str);
                    builder[i] = (char) n;
                    builder[ind] = str[i];
                    max = Math.Max(max, int.Parse(builder.ToString()));
                    k++;
                    (n, ind) = list[k];
                } while (list[i].num == n);

                return max;
            }

            return num;
        }
    }
}
