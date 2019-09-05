using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Valid Palindrome (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            var arr = s.Where(ch => char.IsLetterOrDigit(ch)).Select(ch => char.ToLower(ch)).ToArray();
            for(int i = 0; i<arr.Length/2; i++)
                if (arr[i] != arr[arr.Length - i - 1])
                    return false;

            return true;
        }
    }
}
