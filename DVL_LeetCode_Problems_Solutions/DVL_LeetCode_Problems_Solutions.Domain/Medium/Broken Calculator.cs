namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Broken Calculator (Mine)
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        public static int BrokenCalc(int X, int Y)
        {
            if (Y <= X)
                return X - Y;

            if (Y % 2 == 1)
                return BrokenCalc(X, Y + 1) + 1;
            else return BrokenCalc(X, Y / 2) + 1;
        }
    }
}
