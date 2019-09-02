using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain.Weekly_Contests
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Prime Arrangements (Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int NumPrimeArrangements(int n)
        {
            bool IsPrime(int num)
            {
                for (int i = 2; i <= num / 2; i++)
                    if (num % i == 0)
                        return false;

                return true;
            }

            int mod = (int)Math.Pow(10, 9) + 7;

            int count = 0;
            for (int i = 2; i <= n; i++)
                if (IsPrime(i))
                    count++;

            long res = 1;
            for (int i = count; i > 0; i--)
            {
                res = (res * i) % mod;
                res %= mod;
            }

            for (int i = n - count; i > 0; i--)
            {

                res = (res * i) % mod;
                res %= mod;
            }

            return (int)res;
        }

        /// <summary>
        /// Diet Plan Performance (Mine)
        /// </summary>
        /// <param name="calories"></param>
        /// <param name="k"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static int DietPlanPerformance(int[] calories, int k, int lower, int upper)
        {
            int points=0, sum = 0;
            for (int i = 0; i < calories.Length; i++)
            {
                sum += calories[i];
                if (i + 1 > k)
                {
                    points += sum > upper ? 1 : (sum < lower ? -1 : 0);
                    sum -= calories[i - k + 1];
                }
            }

            return points;
        }

        /// <summary>
        /// Can Make Palindrome from Substring (Allmost Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
        public static IList<bool> CanMakePaliQueries(string s, int[][] queries)
        {
            //bool[] answer = new bool[queries.Length];
            //int[] diffCounts = new int[s.Length];

            //for (int len = 1; len <= s.Length; len++)
            //    diffCounts[len-1] = CountDiffCounts(s.Substring(0, len));

            //for (int i = 0; i < queries.Length; i++)
            //    answer[i] = CanWeMakePalindrome( diffCounts[queries[i][0]],queries[i][2]);

            //return answer;

            //int CountDiffCounts(string str)
            //{
            //    int diffCount = 0;
            //    for (int i = 0; i < str.Length / 2; i++)
            //        if (str[i] != str[str.Length - i - 1])
            //            diffCount++;

            //    return diffCount;
            //}

            //bool CanWeMakePalindrome(int diffCount, int len, int k)
            //{
            //    diffCount = diffCount / 2 + diffCount % 2;

            //    return diffCount <= k || (len % 2 == 1 && diffCount - 1 <= k);
            //}
            bool[] answers = new bool[queries.Length];
            int[][] matrix = new int[s.Length + 1][];
            matrix[0] = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                matrix[i + 1] = matrix[i].ToArray();
                matrix[i + 1][s[i] - 'a']++;
            }

            for (int i = 0; i < queries.Length; i++)
            {
                int stIndex = queries[i][0], endIndex = queries[i][1], k = queries[i][2] , diffCount = 0;
                for (int j = 0; j < 26; j++)
                    if ((matrix[endIndex + 1][j] - matrix[stIndex][j]) % 2 == 1)
                        diffCount++;
                diffCount = diffCount / 2 + diffCount % 2;
                answers[i] = diffCount <= k || ((endIndex - stIndex + 1) % 2 == 1 && diffCount - 1 <= k);
            }

            return answers;
        }

        public static IList<int> FindNumOfValidWords(string[] words, string[] puzzles)
        {
            int[] answer = new int[puzzles.Length];

            var list = new List<HashSet<char>>();
            foreach (var word in words)
                list.Add(new HashSet<char>(word));

            for (int i = 0; i < puzzles.Length; i++)
                answer[i] = ValidWordNumber(puzzles[i]);

            return answer;

            int ValidWordNumber(string puzzle)
            {
                int count = 0;
                foreach (var set in list)
                    if(set.Contains(puzzle[0]) && set.All(ch=>puzzle.Contains(ch)))
                        count++;

                return count;
            }
        }

    }
}
