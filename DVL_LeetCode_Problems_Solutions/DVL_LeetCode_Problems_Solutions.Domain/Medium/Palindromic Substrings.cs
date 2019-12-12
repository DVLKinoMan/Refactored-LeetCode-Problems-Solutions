namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Palindromic Substrings (Mine and Not Mine, but my implementation)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int CountSubstrings(string s)
        {
            //Mine
            //int count = 0;
            //for (int index = 0; index < s.Length; index++)
            //    for (int len = 1; len <= s.Length - index; len++)
            //        if (IsPalindrome(index, index + len - 1))
            //            count++;

            //return count;

            //bool IsPalindrome(int st, int end)
            //{
            //    int len = st + (end - st + 1) / 2;
            //    for (int i = st; i < len; i++)
            //        if (s[i] != s[end - (i - st)])
            //            return false;

            //    return true;
            //}

            //My implementation not my idea
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                FindPalindromes(i,i);
                FindPalindromes(i, i + 1);
            }

            return count;

            void FindPalindromes(int i1, int j1)
            {
                while (i1 >= 0 && j1 < s.Length && s[i1] == s[j1])
                {
                    count++;
                    i1--;
                    j1++;
                }
            }
        }
    }
}
