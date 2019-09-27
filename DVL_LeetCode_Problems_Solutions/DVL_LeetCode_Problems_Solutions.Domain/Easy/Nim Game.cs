namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Nim Game (Time Limit)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="isYourTurn"></param>
        /// <returns></returns>
        public static bool CanWinNim(int n, bool isYourTurn = true)
        {
            if (n <= 3)
                return isYourTurn;

            if (!isYourTurn)
                return CanWinNim(n - 1, true) && CanWinNim(n - 2, true) && CanWinNim(n - 3, true);

            return CanWinNim(n - 1, false) || CanWinNim(n - 2, false) || CanWinNim(n - 3, false);
        }
    }
}
