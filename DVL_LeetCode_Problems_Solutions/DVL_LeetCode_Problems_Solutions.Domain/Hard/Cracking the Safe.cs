using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain.Hard
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Cracking the Safe (Not Working)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static string CrackSafe(int n, int k)
        {
            string strPwd = new string('0', n);
            var sbPwd = new StringBuilder(strPwd);

            var visitedComb = new HashSet<string>();
            visitedComb.Add(strPwd);

            int targetNumVisited = (int) Math.Pow(k, n);

            crackSafeAfter(sbPwd);

            return sbPwd.ToString();

            bool crackSafeAfter(StringBuilder pwd)
            {
                // Base case: all n-length combinations among digits 0..k-1 are visited. 
                if (visitedComb.Count == targetNumVisited)
                {
                    return true;
                }

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
                        if (crackSafeAfter(pwd))
                        {
                            return true;
                        }

                        visitedComb.Remove(newComb);
                        pwd.Insert(pwd.Length - 1, "");
                    }
                }

                return false;
            }
        }
    }
}
