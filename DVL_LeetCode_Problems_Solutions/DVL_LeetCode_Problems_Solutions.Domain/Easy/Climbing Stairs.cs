namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Climbing Stairs (Not Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int ClimbStairs(int n)
        {
            if (n <= 0)
                return 0;
            switch (n)
            {
                case 1:
                    return 1;
                case 2:
                    return 2;
            }

            int all_ways = 0, one_steps_before = 2, two_steps_before = 1;
            for (int i = 2; i < n; i++)
            {
                all_ways = one_steps_before + two_steps_before;
                two_steps_before = one_steps_before;
                one_steps_before = all_ways;
            }

            return all_ways;
        }
    }
}
