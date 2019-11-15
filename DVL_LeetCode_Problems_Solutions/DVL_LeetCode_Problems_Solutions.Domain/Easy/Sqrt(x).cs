namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Sqrt(x) (Mine)
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int MySqrt(int x)
        {
            int a = 0, b = x / 2;
            while (a <= b)
            {
                int root = (a + b) / 2;
                try
                {
                    int square = checked(root * root);
                    if (square == x)
                        return root;
                    if (square < x)
                        a = root + 1;
                    else b = root - 1;
                }
                catch
                {
                    b = root - 1;
                }
            }

            return (long)a * a <= x ? a : b;
        }
    }
}
