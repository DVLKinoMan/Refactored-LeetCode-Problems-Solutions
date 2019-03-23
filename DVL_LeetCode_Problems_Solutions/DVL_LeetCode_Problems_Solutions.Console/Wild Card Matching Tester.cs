using static System.Console;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LeetCode_Problems_Solutions.Console
{
    partial class Tester
    {
        public static void WildCardMatchingTetser()
        {
            while (true)
            {
                Write("s: ");
                string s = ReadLine();
                Write("p: ");
                string p = ReadLine();
                WriteLine(WildCard_IsMatch(s, p));
            }
        }
    }
}
