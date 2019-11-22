using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Decode String (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string DecodeString(string s)
        {
            var builder = new StringBuilder();
            var innerBuilder = new StringBuilder();
            var stack = new Stack<int>();
            var nums = new StringBuilder();
            int count = 0;
            bool isInner = false;
            foreach (var ch in s)
            {
                if (ch == ']' && count == 1)
                {
                    count--;
                    builder.Append(string.Join("",
                        Enumerable.Repeat(DecodeString(innerBuilder.ToString()), stack.Pop())));
                    isInner = false;
                    innerBuilder.Clear();
                }
                else if (isInner)
                {
                    innerBuilder.Append(ch);
                    if (ch == ']')
                        count--;
                    else if (ch == '[')
                        count++;
                }
                else if (char.IsLetter(ch))
                    builder.Append(ch);
                else if (char.IsDigit(ch))
                    nums.Append(ch);
                else if (ch == '[')
                {
                    count++;
                    if (count != 1) 
                        continue;
                    stack.Push(int.Parse(nums.ToString()));
                    nums.Clear();
                    isInner = true;
                }
            }

            return stack.Count != 0 ? string.Join("", Enumerable.Repeat(builder, stack.Pop())) : builder.ToString();
        }
    }
}
