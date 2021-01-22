namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Distinct Subsequences (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static int NumDistinct(string s, string t)
        {
            if (s.Length == 0 || t.Length == 0)
                return 0;

            var din = new int[t.Length + 1,s.Length + 1];
            for (int j = 0; j < s.Length + 1; j++)
                din[0, j] = 1;
            for (int i = 0; i < t.Length; i++)
            for (int j = 0; j < s.Length; j++)
                din[i + 1, j + 1] = t[i] == s[j] ? din[i, j] + din[i + 1, j] : din[i + 1, j];

            return din[t.Length, s.Length];
        }
    }
}
