using System;
using System.Collections.Generic;
using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain.Hard
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Cracking the Safe (Not Mine - My implementation)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static string CrackSafe(int n, int k)
        {
            string strPwd = new string('0', n);
            var sbPwd = new StringBuilder(strPwd);

            var visitedComb2 = new HashSet<string>();
            visitedComb2.Add(strPwd);

            int targetNumVisited = (int) Math.Pow(k, n);

            crackSafeAfter(sbPwd, visitedComb2);

            return sbPwd.ToString();

            bool crackSafeAfter(StringBuilder pwd, HashSet<string> visitedComb)
            {
                if (visitedComb.Count == targetNumVisited)
                    return true;

                var str = new StringBuilder();
                for (int i = pwd.Length - (n - 1); i < pwd.Length; i++)
                    str.Append(pwd[i]);

                string lastDigits = str.ToString();
                for (char ch = '0'; ch < '0' + k; ch++)
                {
                    string newComb = lastDigits + ch;
                    if (!visitedComb.Contains(newComb))
                    {
                        visitedComb.Add(newComb);
                        pwd.Append(ch);
                        if (crackSafeAfter(pwd, visitedComb))
                            return true;

                        visitedComb.Remove(newComb);
                        pwd.Remove(pwd.Length - 1, 1);
                    }
                }

                return false;
            }
        }
    }
}
