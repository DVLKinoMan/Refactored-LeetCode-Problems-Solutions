namespace DVL_LeetCode_Problems_Solutions.Domain.Hard
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Last Substring in Lexicographical Order (Not Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string LastSubstring(string s)
        {
            int i = 0;
            for (int j = 1; j < s.Length; j++)
            {
                int len = 0;
                for (; j + len < s.Length; len++)
                {
                    if(s[i+len]==s[j+len])
                        continue;
                    i = s[j+len]>s[i+len]?j:i;
                    break;
                }

                if (j + len == s.Length)
                    break;
            }

            return s.Substring(i);
        }
    }
}
