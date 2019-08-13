using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain.Easy
{
    partial class ProblemSolver
    {
        /// <summary>
        ///  Student Attendance Record I (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool CheckRecord(string s)
        {
            if (s.Count(ch => ch == 'A') > 1)
                return false;
            int count = 0;
            for(int i=0;i<s.Length;i++)
                if (s[i] == 'L')
                {
                    count++;
                    if (count > 2)
                        return false;
                }
                else
                    count = 0;

            return true;
        }
    }
}
