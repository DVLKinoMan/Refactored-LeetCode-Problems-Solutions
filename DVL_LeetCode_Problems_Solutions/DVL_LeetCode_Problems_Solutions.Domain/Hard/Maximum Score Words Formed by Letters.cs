using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximum Score Words Formed by Letters (Mine)
        /// </summary>
        /// <param name="words"></param>
        /// <param name="letters"></param>
        /// <param name="score"></param>
        /// <returns></returns>
        public static int MaxScoreWords(string[] words, char[] letters, int[] score)
        {
            var lettersCount = new int[26];
            foreach (var letter in letters)
                lettersCount[letter - 'a']++;

            var validWords = new List<(string word, int score)>();
            foreach (var word in words)
            {
                var (isValid, sc) = IsValidWord(word);
                if (isValid)
                    validWords.Add((word, sc));
            }

            int res = MaxScore(0);

            return res;

            //dfs
            int MaxScore(int prevScore)
            {
                int currScore = prevScore;
                for (int i = 0; i < validWords.Count; i++)
                {
                    var (currWord, sc) = validWords[i];
                    bool cont = false;
                    foreach (var ch in currWord)
                    {
                        if (lettersCount[ch - 'a'] == 0)
                            cont = true;
                        lettersCount[ch - 'a']--;
                    }

                    if (cont)
                        goto end;

                    validWords.RemoveAt(i);

                    currScore = Math.Max(currScore, MaxScore(prevScore + sc));

                    validWords.Insert(i, (currWord, sc));

                    end:
                    foreach (var ch in currWord)
                        lettersCount[ch - 'a']++;
                }

                return currScore;
            }

            //Returns if word letters is in letters array and words score
            (bool isValid, int sc) IsValidWord(string word)
            {
                var wordLetters = word.GroupBy(ch => ch)
                                      .Select(gr => new {gr.Key, Count = gr.Count()});

                int sum = 0;
                foreach (var ch in wordLetters)
                {
                    if (lettersCount[ch.Key - 'a'] < ch.Count)
                        return (false, default);
                    sum += (ch.Count * score[ch.Key - 'a']);
                }

                return (true, sum);
            }
        }
    }
}
