namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Mirror Reflaction (Not Mine)
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public static int MirrorReflection(int p, int q)
        {
            while (p % 2 == 0 && q % 2 == 0)
            {
                p /= 2;
                q /= 2;
            }

            if (p % 2 == 0)
                return 2;
            else if (q % 2 == 0)
                return 0;
            else return 1;
        }
    }
}
