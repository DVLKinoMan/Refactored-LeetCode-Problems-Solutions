namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        ///// <summary>
        ///// Wild Card Matching (Time Limit do not passed)
        ///// </summary>
        ///// <param name="s"></param>
        ///// <param name="p"></param>
        ///// <returns></returns>
        //public static bool WildCard_IsMatch(string s, string p)
        //{
        //    if (p.Length == 0 && s.Length != 0)
        //        return false;

        //    int s_i = 0;
        //    for (int i = 0; i < p.Length; i++)
        //    {
        //        if(s_i==s.Length)
        //        {
        //            if (p[i] == '*' && p.Skip(i).All(ch => ch == '*'))
        //                return true;
        //            return false;
        //        }

        //        if (char.IsLetter(p[i]))
        //        {
        //            if (p[i] != s[s_i])
        //                return false;
        //            s_i++;
        //        }
        //        else if (p[i] == '?')
        //            s_i++;
        //        else //Is *
        //        {
        //            int next_p_index = i + 1;
        //            while (next_p_index < p.Length && p[next_p_index] == '*')
        //                next_p_index++;

        //            if (next_p_index == p.Length)
        //                return true;

        //            while (s_i != s.Length)
        //            {
        //                if (WildCard_IsMatch(s.Substring(s_i), p.Substring(next_p_index)))
        //                    return true;
        //                s_i++;
        //            }

        //            return false;
        //        }
        //    }

        //    if (s_i == s.Length)
        //        return true;

        //    return false;
        //}

        //public static bool WildCard_IsMatch(string s, string p)
        //{
        //    if (string.IsNullOrEmpty(p))
        //        return string.IsNullOrEmpty(s);
        //    if (string.IsNullOrEmpty(s))
        //        return false;

        //    bool firstMatch = !string.IsNullOrEmpty(s) && (p[0] == s[0] || p[0] == '?');

        //    if (p[0] == '*')
        //        return WildCard_IsMatch(s, p.Substring(1)) || WildCard_IsMatch(s.Substring(1), p);
        //    else return firstMatch && WildCard_IsMatch(s.Substring(1), p.Substring(1));
        //}

        /// <summary>
        /// Wild Card Matching (Not Mine Solution)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool WildCard_IsMatch(string s, string p)
        {
            int p_i = 0, s_i = 0;
            int starIndex = -1, sIndex = -1;
            while(s_i<s.Length)
            {
                if (p_i < p.Length && (p[p_i] == '?' || s[s_i] == p[p_i]))
                {
                    p_i++;
                    s_i++;
                }
                else if (p_i < p.Length && p[p_i] == '*')
                {
                    starIndex = p_i++;
                    sIndex = s_i;
                }
                else if (starIndex != -1)
                {
                    p_i = starIndex + 1;
                    s_i = sIndex ++;
                }
                else return false;
            }

            while (p_i < p.Length && p[p_i] == '*')
                p_i++;

            return p_i == p.Length;
        }
    }
}
