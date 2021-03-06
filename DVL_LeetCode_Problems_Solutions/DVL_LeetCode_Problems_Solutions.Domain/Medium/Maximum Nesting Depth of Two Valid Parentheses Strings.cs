﻿using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximum Nesting Depth of Two Valid Parentheses Strings (Mine)
        /// </summary>
        /// <param name="seq"></param>
        /// <returns></returns>
        public static int[] MaxDepthAfterSplit(string seq)
        {
            int[] res = new int[seq.Length];
            int depth = 0, maxDepth = 0;
            foreach (var ch in seq)
            {
                if (ch == '(')
                    depth++;
                else if (ch == ')')
                    depth--;
                maxDepth = Math.Max(depth, maxDepth);
            }

            int d = maxDepth / 2;
            depth = 0;
            for (int i = 0; i < res.Length; i++)
            {
                if (seq[i] == '(')
                    depth++;
                else if (seq[i] == ')')
                    depth--;
                if (depth > d || (seq[i] == ')' && depth == d))
                    res[i] = 1;
            }

            return res;
        }
    }
}
