using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Split Array into Fibonacci Sequence (Mine)
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static IList<int> SplitIntoFibonacci(string S)
        {
            var list = new List<int>();
            for (int len = 1; len <= S.Length - 2; len++)
            {
                string str = S.Substring(0, len);
                if ((str=="0" || str[0]!='0') && int.TryParse(str, out int num))
                {
                    list.Add(num);
                    for (int len2 = 1; len2 <= S.Length - len - 1; len2++)
                    {
                        string str2 = S.Substring(len, len2);
                        if ((str2=="0" || str2[0]!='0') && int.TryParse(str2, out int num2))
                        {
                            list.Add(num2);
                            if (IsFibonnaciSequence(num, num2, len + len2))
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
                    return list.Count >= 3;

                int num3 = num1 + num2;
                string str = num3.ToString();

                if ((str.Length != 1 && str[0] == '0') || index + str.Length > S.Length)
                    return false;

                if (S.Substring(index, str.Length) != str)
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
