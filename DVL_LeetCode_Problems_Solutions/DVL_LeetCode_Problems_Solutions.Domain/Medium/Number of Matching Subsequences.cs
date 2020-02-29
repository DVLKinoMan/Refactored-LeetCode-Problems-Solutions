using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Number of Matching Subsequences (Mine)
        /// </summary>
        /// <param name="S"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        public static int NumMatchingSubseq(string S, string[] words) {
            var dict = new Dictionary<char, List<int>>();
            for (int i = 0; i < S.Length; i++)
            {
                if (dict.ContainsKey(S[i]))
                    dict[S[i]].Add(i);
                else dict.Add(S[i], new List<int>() {i});
            }

            return words.Count(word => IsSubsequence(word));

            bool IsSubsequence(string str)
            {
                int ind = -1;
                foreach (var ch in str)
                {
                    if (!dict.ContainsKey(ch))
                        return false;
                    int first = dict[ch].FirstOrDefault(i => i > ind);
                    if (first <= ind)
                        return false;
                    ind = first;
                }

                return true;
            }
        }
    }
}