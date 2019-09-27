namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Nim Game (Not Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="isYourTurn"></param>
        /// <returns></returns>
        public static bool CanWinNim(int n) => n % 4 != 0;
    }
}
