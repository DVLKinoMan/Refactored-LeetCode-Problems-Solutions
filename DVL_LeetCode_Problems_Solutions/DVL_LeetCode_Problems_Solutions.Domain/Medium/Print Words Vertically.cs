using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Print Words Vertically (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static IList<string> PrintVertically(string s)
        {
            var list = new List<string>();
            var words = s.Split(' ');
            int len = words.Max(w => w.Length);
            for (int i = 0; i < len; i++)
            {
                var builder = new StringBuilder();
                for (int j = 0; j < words.Length; j++)
                    if (words[j].Length > i)
                        builder.Append(words[j][i]);
                    else builder.Append(' ');
                list.Add(builder.ToString().TrimEnd());
            }

            return list;
        }
    }
}
