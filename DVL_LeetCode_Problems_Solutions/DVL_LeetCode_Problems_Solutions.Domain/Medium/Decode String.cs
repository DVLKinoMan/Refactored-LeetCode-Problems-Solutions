using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
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
                if (ch == ']')
                {
                    count--;
                    if (count == 0)
                    {
                        builder.Append(string.Join("", Enumerable.Repeat(DecodeString(innerBuilder.ToString()), stack.Pop())));
                        isInner = false;
                        innerBuilder.Clear();
                    }
                }
                else if (isInner && count == 1)
                    innerBuilder.Append(ch);
                else if (char.IsLetter(ch))
                {
                    if (isInner)
                        innerBuilder.Append(ch);
                    else builder.Append(ch);
                }
                else if (char.IsDigit(ch))
                {
                    if (isInner)
                    {
                        innerBuilder.Append(ch);
                        continue;
                    }
                    nums.Append(ch);
                }
                else if (ch == '[')
                {
                    count++;
                    if (count == 1)
                    {
                        stack.Push(int.Parse(nums.ToString()));
                        nums.Clear();
                        isInner = true;
                    }
                }
            }

            return stack.Count!=0 ? string.Join("", Enumerable.Repeat(builder, stack.Pop())) : builder.ToString();
        }
    }
}
