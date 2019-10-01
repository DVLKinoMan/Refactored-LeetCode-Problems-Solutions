using System.Collections.Generic;
using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Remove All Adjacent Duplicates in String II (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static string RemoveDuplicates(string s, int k)
        {
            var str = new StringBuilder(s);
            var stack = new Stack<(char ch, int count)>();

            foreach (var ch in s)
            {
                str.Append(ch);
                if (stack.Count != 0 && stack.Peek().ch == ch)
                {
                    if (stack.Peek().count == k - 1)
                    {
                        str.Remove(str.Length - k, k);
                        stack.Pop();
                    }
                    else
                    {
                        var tup = stack.Pop();
                        stack.Push((ch, tup.count + 1));
                    }
                }
                else stack.Push((ch, 1));
            }

            return str.ToString();
        }
    }
}
