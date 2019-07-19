namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Verifying an Alien Dictionary (Not Mine)
        /// </summary>
        /// <param name="words"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        public static bool IsAlienSorted(string[] words, string order)
        {
            int[] mapping = new int[26];
            for (int i = 0; i < order.Length; i++)
                mapping[order[i] - 'a'] = i;
            for (int i = 1; i < words.Length; i++)
                if (IsAlienSortedHelper(words[i - 1], words[i], mapping) > 0)
                    return false;
            return true;
        }

        private static int IsAlienSortedHelper(string s1, string s2, int[] mapping)
        {
            int n = s1.Length, m = s2.Length, cmp = 0;
            for (int i = 0, j = 0; i < n && j < m && cmp == 0; i++, j++)
                cmp = mapping[s1[i] - 'a'] - mapping[s2[j] - 'a'];
            return cmp == 0 ? n - m : cmp;
        }
    }
}
