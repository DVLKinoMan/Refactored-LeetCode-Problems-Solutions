namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Repeated Substring Pattern (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool RepeatedSubstringPattern(string s)
        {
            for (int len = 1; len <= s.Length / 2; len++)
            {
                if (s.Length % len != 0)
                    continue;
                string str = s.Substring(0, len);
                int i = len;
                while (i < s.Length && s.Substring(i, len) == str)
                    i += len;
                if (i >= s.Length)
                    return true;
            }

            return false;
        }
    }
}
