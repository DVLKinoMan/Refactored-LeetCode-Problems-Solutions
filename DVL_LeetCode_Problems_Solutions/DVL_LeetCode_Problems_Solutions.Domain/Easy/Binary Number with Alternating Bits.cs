namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Binary Number with Alternating Bits (Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool HasAlternatingBits(int n)
        {
            //My Version Which is Faster in leetcode
            string str = System.Convert.ToString(n, 2);
            for (int i = 1; i < str.Length; i++)
                if (str[i] == str[i - 1])
                    return false;

            return true;

            //This is Slower
            //n ^= (n >> 1);
            //return (n & n + 1) == 0;
        }
    }
}
