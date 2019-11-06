using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// To Lower Case (Mine)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToLowerCase(string str)
        {
            var res = new StringBuilder();
            foreach (var ch in str)
            {
                if (char.IsUpper(ch))
                {
                    int diff = ch - 'A';
                    res.Append((char)('a' + diff));
                }
                else res.Append(ch);
            }

            return res.ToString();
        }
    }
}
