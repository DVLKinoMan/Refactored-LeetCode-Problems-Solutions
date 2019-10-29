namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Flip String to Monotone Increasing (Not Mine)
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static int MinFlipsMonoIncr(string S)
        {
            if (S == null)
                return 0;

            int count = 0, onesCount = 0;
            foreach (var ch in S)
            {
                if (ch == '0')
                {
                    if (onesCount == 0)
                        continue;
                    count++;
                }
                else onesCount++;

                if (count > onesCount)
                    count = onesCount;
            }

            return count;
        }
    }
}
