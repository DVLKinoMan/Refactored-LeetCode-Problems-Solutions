using System.Collections.Generic;
using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Letter Case Permutation (Mine)
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static IList<string> LetterCasePermutation(string S)
        {
            var list = new List<string>();
            Dfs(new StringBuilder(), 0);
            return list;

            void Dfs(StringBuilder str, int i)
            {
                if (i >= S.Length)
                {
                    list.Add(str.ToString());
                    return;
                }

                if (char.IsLetter(S[i]))
                {
                    str.Append(char.ToUpper(S[i]));
                    Dfs(str, i + 1);
                    str.Remove(i, 1);
                    str.Append(char.ToLower(S[i]));
                    Dfs(str, i + 1);
                    str.Remove(i, 1);
                }
                else
                {
                    str.Append(S[i]);
                    Dfs(str, i + 1);
                    str.Remove(i, 1);
                }
            }
        }
    }
}
