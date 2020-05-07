using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Destination City (Mine)
        /// </summary>
        /// <param name="paths"></param>
        /// <returns></returns>
        public static string DestCity(IList<IList<string>> paths)
        {
            var dict = new Dictionary<string, string>();
            foreach (var path in paths)
                dict[path[0]] = path[1];
            return dict.First(keyValue => !dict.ContainsKey(keyValue.Value)).Value;
        }
    }
}