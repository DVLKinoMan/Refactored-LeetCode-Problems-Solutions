namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Reverse String (Mine)
        /// </summary>
        /// <param name="s"></param>
        public static void ReverseString(char[] s)
        {
            for (int i = 0; i < s.Length/2; i++)
            {
                char ch = s[i];
                s[i] = s[s.Length - i - 1];
                s[s.Length - i - 1] = ch;
            }
        }
    }
}
