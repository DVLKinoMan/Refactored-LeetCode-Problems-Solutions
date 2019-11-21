namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Valid Perfect Square (Mine)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsPerfectSquare(int num)
        {
            int a = 0, b = num;
            while (a <= b)
            {
                long curr = (a + b) / 2;
                long square = curr * curr;
                if (square == num)
                    return true;
                if (square > num)
                    b = (int)curr - 1;
                else a = (int)curr + 1;
            }

            return false;
        }
    }
}
