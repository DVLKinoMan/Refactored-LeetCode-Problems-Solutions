using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximum Score Words Formed by Letters (Not Working)
        /// </summary>
        /// <param name="words"></param>
        /// <param name="letters"></param>
        /// <param name="score"></param>
        /// <returns></returns>
        public static int MaxScoreWords(string[] words, char[] letters, int[] score)
        {
            var dict = new Dictionary<char, int>();
            foreach (var letter in letters)
            {
                if (dict.ContainsKey(letter))
                    dict[letter]++;
                else dict.Add(letter, 1);
            }

            var listWords = words.ToList();
            var listOfScores = new List<int>();
            for (int i = 0; i < listWords.Count; i++)
            {
                var (isValid, sc) = IsValidWord(listWords[i]);
                if (!isValid)
                {
                    listWords.RemoveAt(i);
                    i--;
                }
                else listOfScores.Add(sc);
            }

            int res = 0;

            return MaxScore(0);

            int MaxScore(int currScore)
            {
                for (int i = 0; i < listWords.Count; i++)
                {
                    string currWord = listWords[i];
                    foreach (var ch in currWord)
                    {
                        if (dict[ch] == 0)
                            return currScore;
                        dict[ch]--;
                    }
                    listWords.RemoveAt(i);
                    int prevScore = listOfScores[i];
                    listOfScores.RemoveAt(i);
                    res = Math.Max(res, MaxScore(currScore + prevScore));
                    listWords.Insert(i, currWord);
                    listOfScores.Insert(i, prevScore);
                }

                return res;
            }

            (bool isValid, int sc) IsValidWord(string word)
            {
                var dict2 = new Dictionary<char,int>();
                foreach (var ch in word)
                {
                    if (dict2.ContainsKey(ch))
                        dict2[ch]++;
                    else dict2.Add(ch, 1);
                }

                int sum = 0;
                foreach (var ch in dict2)
                {
                    if (!dict.ContainsKey(ch.Key) || dict[ch.Key] < ch.Value)
                        return (false, -1);
                    sum += (dict[ch.Key] * score[ch.Key - 'a']);
                }

                return (true, sum);
            }
        }
    }
}
