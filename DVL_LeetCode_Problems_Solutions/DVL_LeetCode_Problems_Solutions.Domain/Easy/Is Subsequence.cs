namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Is Subsequence (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool IsSubsequence(string s, string t)
        {
            int si = 0, ti = 0;
            while (si < s.Length && ti < t.Length)
            {
                if (s[si] == t[ti])
                    si++;
                ti++;
            }

            return si == s.Length;
        }
    }
}