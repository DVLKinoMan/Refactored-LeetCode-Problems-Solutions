namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Minimum Swaps to make String Equal (Not Mine)
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static int MinimumSwap(string s1, string s2)
        {
            int x1 = 0, y1 = 0, x2 = 0,y2 = 0; 

            for (int i = 0; i < s1.Length; i++)
            {
                char c1 = s1[i],c2 = s2[i];
                if (c1 == c2)
                    continue;

                if (c1 == 'x')
                    x1++;
                else
                    y1++;
                if (c2 == 'x')
                    x2++;
                else
                    y2++;
            }

            if ((x1 + x2) % 2 != 0 || (y1 + y2) % 2 != 0)
                return -1; 

            int swaps = x1 / 2 + y1 / 2 + (x1 % 2) * 2;

            return swaps;
        }
    }
}
