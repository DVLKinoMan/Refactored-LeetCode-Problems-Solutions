namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Minimum Flips to Make a OR b Equal to c (Mine)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int MinFlips(int a, int b, int c)
        {
            int count = 0;
            while (a != 0 || b != 0)
            {
                if (((a & 1) | (b & 1)) != (c & 1))
                {
                    if (((a & 1) & (b & 1)) == 1)
                        count++;
                    count++;
                }
                a >>= 1;
                b >>= 1;
                c >>= 1;
            }

            while (c != 0)
            {
                if ((c & 1) == 1)
                    count++;
                c >>= 1;
            }

            return count;
        }
    }
}
