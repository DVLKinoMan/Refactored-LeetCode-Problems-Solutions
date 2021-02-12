using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Remove Invalid Parentheses (NOt Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static IList<string> RemoveInvalidParentheses(string s)
        {
            var ans = new List<string>();
            Rec(s, 0, 0, new char[] {'(', ')'});
            return ans;

            void Rec(string s, int last_i, int last_j, char[] par)
            {
                for (int count = 0, i = last_i; i < s.Length; i++)
                {
                    if (s[i] == par[0])
                        count++;
                    else if (s[i] == par[1])
                        count--;
                    if (count >= 0)
                        continue;
                    for (int j = last_j; j <= i; j++)
                        if (s[j] == par[1] && (j == last_j || s[j - 1] != par[1]))
                            Rec(s.Substring(0, j) + s.Substring(j + 1), i, j, par);
                    return;
                }

                var reversed = string.Join("", s.Reverse());
                if (par[0] == '(')
                    Rec(reversed, 0, 0, new char[] {')', '('});
                else
                    ans.Add(reversed);
            }

        }
    }
