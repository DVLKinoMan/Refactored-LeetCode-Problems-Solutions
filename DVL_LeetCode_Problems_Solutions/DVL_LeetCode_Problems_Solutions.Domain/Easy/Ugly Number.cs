namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Ugly Number
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsUgly(int num)
        {
            if (num == 0)
                return false;
            if (num == 1)
                return true;

            if (num % 2 == 0)
                return IsUgly(num / 2);
            if (num % 3 == 0)
                return IsUgly(num / 3);
            if (num % 5 == 0)
                return IsUgly(num / 5);

            return false;
        }
    }
}
