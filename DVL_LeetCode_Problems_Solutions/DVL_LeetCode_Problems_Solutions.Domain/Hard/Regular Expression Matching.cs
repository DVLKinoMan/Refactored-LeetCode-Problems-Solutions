namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        //My solution, which was not correct
        //public static bool IsMatch(string s, string p)
        //{
        //    if (string.IsNullOrEmpty(p) && !string.IsNullOrEmpty(s))
        //        return false;

        //    int si = 0;
        //    for(int pi = 0; pi < p.Length; pi++)
        //    {
        //        if (si >= s.Length)
        //        {
        //            if (p[pi] == '*' || (pi + 1 < p.Length && p[pi + 1] == '*'))
        //                continue;
        //            return false;
        //        }

        //        if(p[pi]!='.' && p[pi] != '*')
        //        {
        //            if (p[pi] != s[si])
        //            {
        //                if (pi + 1 < p.Length && p[pi + 1] == '*')
        //                    pi++;
        //                else
        //                    return false;
        //            }
        //            else si++;
        //        }
        //        else
        //        {
        //            if (p[pi] == '*')
        //            {
        //                char previousChar = p[pi - 1];
        //                if (previousChar != '.')
        //                {
        //                    while (si < s.Length && s[si] == previousChar)
        //                    {
        //                        si++;
        //                        if (pi + 1 < p.Length && p[pi+1] == previousChar)
        //                            pi++;
        //                    }
        //                }
        //                else
        //                {
        //                    char schar = s[si];
        //                    while (si < s.Length && s[si] == schar)
        //                        si++;
        //                }
        //            }
        //            else
        //                si++;
        //        }
        //    }

        //    if (si != s.Length)
        //        return false;

        //    return true;
        //}

        /// <summary>
        /// Regular_Expression_Matching
        /// </summary>
        /// <param name="text"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static bool IsMatch(string text, string pattern)
        {
            if (string.IsNullOrEmpty(pattern)) return string.IsNullOrEmpty(text);
            bool first_match = (!string.IsNullOrEmpty(text) &&
                                   (pattern[0] == text[0] || pattern[0] == '.'));

            if (pattern.Length >= 2 && pattern[1] == '*')
            {
                return (IsMatch(text, pattern.Substring(2)) ||
                        (first_match && IsMatch(text.Substring(1), pattern)));
            }
            else
            {
                return first_match && IsMatch(text.Substring(1), pattern.Substring(1));
            }
        }

        /// <summary>
        /// Regular_Expression_Matching
        /// </summary>
        /// <param name="text"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static bool IsMatch2(string text, string pattern)
        {
            bool[,] dp = new bool[text.Length + 1, pattern.Length + 1];
            dp[text.Length, pattern.Length] = true;

            for (int i = text.Length; i >= 0; i--)
            {
                for (int j = pattern.Length - 1; j >= 0; j--)
                {
                    bool first_match = (i < text.Length &&
                                           (pattern[j] == text[i] ||
                                            pattern[j] == '.'));
                    if (j + 1 < pattern.Length && pattern[j + 1] == '*')
                    {
                        dp[i, j] = dp[i, j + 2] || first_match && dp[i + 1, j];
                    }
                    else
                    {
                        dp[i, j] = first_match && dp[i + 1, j + 1];
                    }
                }
            }
            return dp[0, 0];
        }
    }
}
