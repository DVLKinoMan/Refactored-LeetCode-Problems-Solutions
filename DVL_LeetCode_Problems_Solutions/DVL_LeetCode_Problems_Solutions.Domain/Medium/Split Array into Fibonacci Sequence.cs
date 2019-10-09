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
        /// Split Array into Fibonacci Sequence (Not Working)
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static IList<int> SplitIntoFibonacci(string S)
        {
            var list = new List<int>();
            for (int i = 0; i < S.Length; i++)
            for (int len = 1; len <= S.Length - i - 2; len++)
            {
                if (int.TryParse(S.Substring(i, len), out int num))
                {
                    list.Add(num);
                    for (int len2 = 1; len2 <= S.Length - len - 1; len2++)
                    {
                        if (int.TryParse(S.Substring(i + len, len2), out int num2))
                        {
                            list.Add(num2);
                            if (IsFibonnaciSequence(num, num2, i + len + len2))
                                return list;
                            list.RemoveAt(list.Count - 1);
                        }
                        else break;
                    }

                    list.RemoveAt(list.Count - 1);
                }
                else break;
            }

            return list;

            bool IsFibonnaciSequence(int num1, int num2, int index)
            {
                if (index >= S.Length)
                    return true;

                int num3 = num1 + num2;
                string str = num3.ToString();
                if(S.Substring(index, str.Length) != str)
                    return false;

                list.Add(num3);

                if (IsFibonnaciSequence(num2, num3, index + str.Length))
                    return true;

                list.RemoveAt(list.Count - 1);
                return false;
            }
        }
    }
}
