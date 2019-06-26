using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Bulls and Cows (Mine)
        /// </summary>
        /// <param name="secret"></param>
        /// <param name="guess"></param>
        /// <returns></returns>
        public static string GetHint(string secret, string guess)
        {
            int bullsCount = 0, cowsCount = 0;
            var bullsPositions = new List<int>();
            for(int i=0; i<secret.Length; i++)
                if (secret[i] == guess[i])
                {
                    bullsCount++;
                    bullsPositions.Add(i);
                }

            var list1 = new List<int>();
            var list2 = new List<int>();
            for(int i = 0; i<secret.Length;i++)
                if (!bullsPositions.Contains(i))
                {
                    list1.Add(secret[i]);
                    list2.Add(guess[i]);
                }

            for (int i = 0; i < list1.Count; i++)
            {
                int index = list2.IndexOf(list1[i]);
                if (index >= 0)
                {
                    cowsCount++;
                    list1.RemoveAt(i);
                    list2.RemoveAt(index);
                    i--;
                }
            }

            return $"{bullsCount}A{cowsCount}B";
        }
    }
}
