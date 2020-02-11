namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Number of Steps to Reduce a Number to Zero (Mine)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int NumberOfSteps (int num)
        {
            int count = 0;
            while (num != 0)
            {
                if (num % 2 == 0)
                    num /= 2;
                else num--;
                count++;
            }

            return count;
        }
    }
}