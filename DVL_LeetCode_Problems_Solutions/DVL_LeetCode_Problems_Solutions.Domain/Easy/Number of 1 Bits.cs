namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Number of 1 Bits (Not Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int HammingWeight(uint n)
        {
            long ones = 0;
            while (n != 0)
            {
                ones = ones + (n & 1);
                n = n >> 1;
            }
            return (int)ones;
        }
    }
}
