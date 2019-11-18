using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Sort Characters By Frequency (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string FrequencySort(string s) => string.Join("",s.GroupBy(ch=>ch).OrderByDescending(gr=>gr.Count()).SelectMany(gr=>gr));
    }
}
