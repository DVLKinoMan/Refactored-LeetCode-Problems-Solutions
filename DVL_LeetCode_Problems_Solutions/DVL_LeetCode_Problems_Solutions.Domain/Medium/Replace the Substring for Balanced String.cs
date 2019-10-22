using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Replace the Substring for Balanced String (Not Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int BalancedString(string s)
        {
            //var count = (0, 0, 0, 0);
            //foreach (var ch in s)
            //{
            //    switch (ch)
            //    {
            //        case 'Q':
            //            count.Item1++;
            //            break;
            //        case 'W':
            //            count.Item2++;
            //            break;
            //        case 'E':
            //            count.Item3++;
            //            break;
            //        case 'R':
            //            count.Item4++;
            //            break;
            //    }
            //}

            //(int Qcount, int Wcount, int Ecount, int Rcount) = count;
            //int n = s.Length / 4;
            //if (Qcount == Wcount && Ecount == Rcount && Qcount == Ecount)
            //    return 0;

            int[] count = new int[128];
            int n = s.Length, res = n, i = 0;
            for (int j = 0; j < n; ++j)
                ++count[s[j]];
            for (int j = 0; j < n; ++j)
            {
                --count[s[j]];
                while (i < n && count['Q'] <= n / 4 && count['W'] <= n / 4 && count['E'] <= n / 4 && count['R'] <= n / 4)
                {
                    res = Math.Min(res, j - i + 1);
                    ++count[s[i++]];
                }
            }
            return res;
        }
    }
}
