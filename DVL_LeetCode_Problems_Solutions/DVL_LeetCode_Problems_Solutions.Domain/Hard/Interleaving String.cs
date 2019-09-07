namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Interleaving String (Mine)
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="s3"></param>
        /// <returns></returns>
        public static bool IsInterleave(string s1, string s2, string s3)
        {
            bool recFunc(int i, int j, int k) =>
                (i == s1.Length && j == s2.Length && k == s3.Length) ||
                (
                    k != s3.Length && (
                        (i < s1.Length && s1[i] == s3[k] && recFunc(i + 1, j, k + 1)) ||
                        (j < s2.Length && s2[j] == s3[k] && recFunc(i, j + 1, k + 1))
                    )
                );

            return recFunc(0, 0, 0);
        }
    }
}
