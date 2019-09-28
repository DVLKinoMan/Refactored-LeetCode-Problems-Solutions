using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Replace Words (Mine)
        /// </summary>
        /// <param name="dict"></param>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public static string ReplaceWords(IList<string> dict, string sentence)
        {
            string[] res = sentence.Split(' ');
            var orderedDict = dict.OrderBy(root => root.Length);

            for (int i = 0; i < res.Length; i++)
            {
                foreach (var root in orderedDict)
                    if (IsSuccessor(root, res[i]))
                    {
                        res[i] = root;
                        break;
                    }
            }

            return string.Join(" ", res);

            bool IsSuccessor(string root, string potSuccessor)
            {
                if (potSuccessor.Length < root.Length)
                    return false;

                for (int i = 0; i < root.Length; i++)
                    if (potSuccessor[i] != root[i])
                        return false;

                return true;
            }
        }
    }
}
