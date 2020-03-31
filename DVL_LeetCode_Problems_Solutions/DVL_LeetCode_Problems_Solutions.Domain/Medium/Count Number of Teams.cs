namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Count Number of Teams (Not Mine)
        /// </summary>
        /// <param name="rating"></param>
        /// <returns></returns>
        public static int NumTeams(int[] rating)
        {
            int res = 0;
            for (int i = 1; i < rating.Length - 1; ++i)
            {
                var less = new int[2];
                var greater = new int[2];
                for (int j = 0; j < rating.Length; ++j)
                {
                    if (rating[i] < rating[j])
                        ++less[j > i ? 1 : 0];
                    if (rating[i] > rating[j])
                        ++greater[j > i ? 1 : 0];
                }

                res += less[0] * greater[1] + greater[0] * less[1];
            }

            return res;
        }
    }
}