using System.Linq;
using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Remove Palindromic Subsequences (Not Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int RemovePalindromeSub(string s)
        {
            return string.IsNullOrEmpty(s) ? 0 :
                s == string.Join("", new StringBuilder(s).ToString().Reverse()) ? 1 : 2;
        }
    }
}
