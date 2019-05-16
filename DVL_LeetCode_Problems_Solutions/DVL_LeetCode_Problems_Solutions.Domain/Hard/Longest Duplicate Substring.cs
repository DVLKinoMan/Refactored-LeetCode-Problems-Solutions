using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        ///// <summary>
        ///// Do not Works
        ///// </summary>
        ///// <param name="S"></param>
        ///// <returns></returns>
        //public static string LongestDupSubstring(string S)
        //{
        //    string result = string.Empty;

        //    int start = 1, end = S.Length - 1;
        //    while (start <= end)
        //    {
        //        int currLen = (start + end) / 2;
        //        var set = new HashSet<string>();
        //        int i = 0;
        //        bool isWithLen = false;
        //        while (i + currLen <= S.Length)
        //        {
        //            string subString = S.Substring(i, currLen);
        //            if (!set.Add(subString))
        //            {
        //                isWithLen = true;
        //                result = subString;
        //                start = currLen + 1;
        //                break;
        //            }

        //            i++;
        //        }

        //        if (!isWithLen)
        //            end = currLen - 1;
        //    }

        //    return result;
        //}

        public static string LongestDupSubString(string S)
        {
            int lo = 0, hi = S.Length;
            // binary search to find SMALLEST length of string that cannot pass test
            while (lo < hi)
            {
                int mid = lo + (hi - lo) / 2;
                int index = LongestDupSubStringTest(S, mid);
                if (index < 0) hi = mid;
                else
                {
                    lo = mid + 1;
                }
            }
            // lo-1 is the LARGEST length of string that CAN pass test
            int checkLen = lo - 1;
            if (checkLen <= 0) return "";
            int start = LongestDupSubStringTest(S, checkLen);
            return S.Substring(start, checkLen);
        }

        private static readonly long q = 2147483647;

        private static long LongestDupSubStringHash(string key, int m)
        {
            long h = 0;
            for (int j = 0; j < m; j++)
            {
                h = (256 * h + key[j]) % q;
            }
            return h;
        }

        private static bool LongestDupSubStringCompare(string s, int i1, int i2, int m)
        {
            for (int i = 0; i < m; i++)
            {
                if (s[i1 + i] != s[i2 + i]) return false;
            }
            return true;
        }

        private static int LongestDupSubStringTest(string s, int m)
        {
            var map = new Dictionary<long, List<int>>();
            long h = LongestDupSubStringHash(s, m);
            map.Add(h, new List<int>());
            map[h].Add(0);

            long RM = 1; // R^(m-1) % q
            for (int i = 1; i <= m - 1; i++)
                RM = (256 * RM) % q;

            // NOTE i is the ending index of current string
            for (int i = m; i < s.Length; i++)
            {
                // remove leading digit, add trailing digit, check for match
                h = (h + q - RM * s[i - m] % q) % q;
                h = (h * 256 + s[i]) % q;
                int startIndex = i - m + 1;
                if (map.ContainsKey(h))
                    foreach (int prev in map[h])
                        if (LongestDupSubStringCompare(s, startIndex, prev, m))
                            return startIndex;
                else
                    map.Add(h, new List<int>());
                
                map[h].Add(startIndex);
            }

            return -1;
        }

    }
}
