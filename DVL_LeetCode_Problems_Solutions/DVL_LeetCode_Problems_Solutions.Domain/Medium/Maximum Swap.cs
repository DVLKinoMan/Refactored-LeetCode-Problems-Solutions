using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int MaximumSwap(int num)
        {
            var str = num.ToString();
            var list = new List<(int num, int index)>();
            for (int i = 0; i < str.Length; i++)
                list.Add((str[i], i));

            int ind = 0, max = num;
            bool foundAnswer = false;
            StringBuilder builder;
            foreach (var gr in list.OrderByDescending(l => l.num).GroupBy(l=>l.num))
            {
                foreach (var (n, index) in gr)
                {
                    if (str[ind] == n) 
                        continue;
                    foundAnswer = true;
                    builder = new StringBuilder(str);
                    char ch = str[ind];
                    builder[ind] = (char) n;
                    builder[index] = ch;
                    max = Math.Max(max, int.Parse(builder.ToString()));
                }

                if (foundAnswer)
                    return max;

                ind++;
            }

            return max;
        }
    }
}
