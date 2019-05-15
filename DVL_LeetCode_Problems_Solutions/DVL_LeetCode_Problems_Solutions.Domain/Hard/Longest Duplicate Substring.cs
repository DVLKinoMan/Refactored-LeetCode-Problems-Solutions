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
        /// Do not Works
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static string LongestDupSubstring(string S)
        {
            string result = string.Empty;

            int start = 1, end = S.Length - 1;
            while (start <= end)
            {
                int currLen = (start + end) / 2;
                var set = new HashSet<string>();
                int i = 0;
                bool isWithLen = false;
                while (i + currLen <= S.Length)
                {
                    string subString = S.Substring(i, currLen);
                    if (!set.Add(subString))
                    {
                        isWithLen = true;
                        result = subString;
                        start = currLen + 1;
                        break;
                    }
                    i++;
                }

                if (!isWithLen)
                    end = currLen - 1;
            }

            return result;
        }
    }
}
