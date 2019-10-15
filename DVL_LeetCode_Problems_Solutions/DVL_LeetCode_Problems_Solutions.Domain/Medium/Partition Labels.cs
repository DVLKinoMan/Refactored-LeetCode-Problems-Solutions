using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        ///  Partition Labels (Mine)
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static IList<int> PartitionLabels(string S)
        {
            var dicRanges = new Dictionary<char, (int i,int j)>();
            for (int i = 0; i < S.Length; i++)
            {
                if (dicRanges.ContainsKey(S[i]))
                    dicRanges[S[i]] = (dicRanges[S[i]].i, i);
                else dicRanges.Add(S[i], (i, i));
            }

            var stack = new Stack<(int i,int j)>();
            foreach (var range in dicRanges.OrderBy(d => d.Value.i).Select(d => d.Value))
            {
                if (stack.Count != 0 && stack.Peek().j > range.i)
                {
                    var currRange = stack.Pop();
                    stack.Push((currRange.i, Math.Max(currRange.j, range.j)));
                }
                else stack.Push(range);
            }

            return stack.OrderBy(s => s.i).Select(s => s.j - s.i + 1).ToList();
        }
    }
}
