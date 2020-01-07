using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Verbal Arithmetic Puzzle (Not Mine)
        /// </summary>
        /// <param name="words"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool IsSolvable(string[] words, string result)
        {
            int[] charValues = new int[26];
            bool[] isFirstWordChar = new bool[26];

            var charsSet = new HashSet<char>();
            foreach (var word in words)
                for (int i = 0; i < word.Length; i++)
                {
                    if (i == 0)
                        isFirstWordChar[word[i] - 'A'] = true;
                    charsSet.Add(word[i]);
                    charValues[word[i] - 'A'] += (int)Math.Pow(10, word.Length - i - 1);
                }

            for (int i = 0; i < result.Length; i++)
            {
                if (i == 0)
                    isFirstWordChar[result[i] - 'A'] = true;
                charsSet.Add(result[i]);
                charValues[result[i] - 'A'] -= (int)Math.Pow(10, result.Length - i - 1);
            }

            int visited = 0;
            long sum = 0L;
            char[] distinctChars = charsSet.ToArray();

            if (dfs(0, sum))
                return true;

            return false;

            bool dfs(int charIndex, long sum1)
            {
                if (charIndex == distinctChars.Length)
                    return sum1 == 0;

                for (int d = 0; d <= 9; d++)
                {
                    if (d == 0 && isFirstWordChar[distinctChars[charIndex] - 'A'])
                        continue;

                    if ((visited & (1 << d)) == 0)
                    {
                        visited |= (1 << d);

                        if (dfs(charIndex + 1, sum1 + charValues[distinctChars[charIndex] - 'A'] * d))
                            return true;

                        visited ^= (1 << d);
                    }
                }

                return false;
            }
        }
    }
}
