using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Number Complement (Mine)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int FindComplement(int num)=> System.Convert.ToInt32(string.Join("", System.Convert.ToString(num, 2).Select(b => b == '0' ? '1' : '0')), 2);
    }
}
