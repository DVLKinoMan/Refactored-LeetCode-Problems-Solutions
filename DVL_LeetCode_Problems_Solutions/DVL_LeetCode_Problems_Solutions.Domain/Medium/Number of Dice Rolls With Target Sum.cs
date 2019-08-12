namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Number of Dice Rolls With Target Sum (Not Mine)
        /// </summary>
        /// <param name="d"></param>
        /// <param name="f"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int NumRollsToTarget(int d, int f, int target)
        {
            return NumRollsToTargetHelper(d, f, target, new int[31, 1001]);
        }

        public static int NumRollsToTargetHelper(int d, int f, int target, int[,] dp, int res = 0)
        {
            if (d == 0 || target <= 0)
                return d == target ? 1 : 0;

            if (dp[d, target] != 0)
                return dp[d, target] - 1;
            for (int i = 1; i <= f; i++)
                res = (res + NumRollsToTargetHelper(d - 1, f, target - i, dp)) % 1000000007;
            dp[d, target] = res + 1;
                
            return res;
        }
    }
}
