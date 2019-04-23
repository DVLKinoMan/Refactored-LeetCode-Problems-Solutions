namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Clumsy Factorial (My Solution)
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static int Clumsy(int N)
        {
            int i = N-1, c=0, result = N, prevResult = 0;
            while (i != 0)
            {
                int mod = c % 4;
                if (mod == 0)
                    result *= i;
                else if (mod == 1)
                    result /= i;
                else if (mod == 2)
                {
                    if (prevResult != 0)
                    {
                        result = prevResult - result;
                        prevResult = 0;
                    }
                    result += i;
                }
                else
                {
                    prevResult = result;
                    result = i;
                }

                c++;
                i--;
            }

            if (prevResult != 0)
                return prevResult - result;
            return result;
        }
    }
}
