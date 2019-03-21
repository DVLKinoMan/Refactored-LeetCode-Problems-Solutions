using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static int LengthOfLastWord(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            var arr = s.Split(' ').Where(str=>str!="");
            return arr.Last().Length;
        }
    }
}
