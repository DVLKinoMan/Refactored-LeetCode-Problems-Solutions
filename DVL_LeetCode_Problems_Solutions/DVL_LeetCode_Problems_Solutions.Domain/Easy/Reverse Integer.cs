using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static int Reverse(int x)
        {
            string str = x.ToString();
            str = string.Concat(str.Where(ch => ch != '-').Reverse());
            int.TryParse(x < 0 ? '-' + str : str, out int result);
            return result;
        }
    }
}
