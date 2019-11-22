using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Reverse Vowels of a String (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseVowels(string s)
        {
            var set = new HashSet<char>() {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var indexes = s.Select((ch, i) => (ch: ch, index: i)).Where(tup => set.Contains(tup.ch))
                .Select(tup => tup.index).ToList();
            var builder = new StringBuilder(s);
            for (int i = 0; i < indexes.Count/2; i++)
            {
                var ch = builder[indexes[i]];
                builder[indexes[i]] = builder[indexes[indexes.Count-i-1]];
                builder[indexes[indexes.Count - i - 1]] = ch;
            }

            return builder.ToString();
        }
    }
}
