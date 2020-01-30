using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Detect Capital (Mine)
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static bool DetectCapitalUse(string word)
        {
            return word.All(char.IsUpper) || 
                   word.All(char.IsLower) || 
                   char.IsUpper(word[0]) && word.Skip(1).All(char.IsLower);
        }
    }
}
