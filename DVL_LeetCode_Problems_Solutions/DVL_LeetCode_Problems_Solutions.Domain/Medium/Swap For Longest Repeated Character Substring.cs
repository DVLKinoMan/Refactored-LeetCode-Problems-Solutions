using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        ///  Swap For Longest Repeated Character Substring (Mine)
        /// </summary>
        /// <param name="text"></param>
        /// <param name="isFirstTime"></param>
        /// <returns></returns>
        public static int MaxRepOpt1(string text, bool isFirstTime = true)
        {
            if (text.Length == 0)
                return 0;

            var list = new List<(int, int)>();
            var lastIndexes = new Dictionary<char, int>();

            int len = 1;
            lastIndexes.Add(text[0], 0);
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == text[i - 1])
                    len++;
                else
                {
                    list.Add((i - len, len));
                    len = 1;
                }

                if (lastIndexes.ContainsKey(text[i]))
                    lastIndexes[text[i]] = i;
                else lastIndexes.Add(text[i], i);
            }

            list.Add((text.Length - len, len));

            int res = list[0].Item2;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].Item2 == 1 && lastIndexes[text[list[i - 1].Item1]] > i)//Some character can be swapped
                {
                    if (i + 1 < list.Count && text[list[i + 1].Item1] == text[list[i - 1].Item1])
                        res = Math.Max(res, list[i - 1].Item2 + list[i + 1].Item2 + (list[i + 1].Item1 + list[i + 1].Item2 - 1 < lastIndexes[text[list[i - 1].Item1]] ? 1 : 0));
                    else res = Math.Max(res, list[i - 1].Item2 + 1);
                }
                else if (lastIndexes[text[list[i - 1].Item1]] > i)
                    res = Math.Max(res, list[i - 1].Item2 + 1);
            }

            return Math.Max(res,isFirstTime ? MaxRepOpt1(string.Join("", text.Reverse()), false) : 0);
        }
    }
}
