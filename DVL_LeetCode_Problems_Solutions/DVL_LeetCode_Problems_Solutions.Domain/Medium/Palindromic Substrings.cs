namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Palindromic Substrings (Not Working)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int CountSubstrings(string s)
        {
            int count = 0;
            for (int index = 0; index < s.Length; index++)
                for (int len = 1; len <= s.Length - index; len++)
                    if (IsPalindrome(index, index + len - 1))
                        count++;

            return count;

            bool IsPalindrome(int st, int end)
            {
                int len = (end - st + 1) / 2;
                for (int i = st; i < len; i++)
                    if (s[i] != s[end - (i - st)])
                        return false;

                return true;
            }
        }
    }
}
