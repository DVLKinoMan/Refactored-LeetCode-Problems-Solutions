using System;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximum Points You Can Obtain from Cards (Mine)
        /// </summary>
        /// <param name="cardPoints"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int MaxScore(int[] cardPoints, int k)
        {
            if (k > cardPoints.Length)
                return cardPoints.Sum();
            
            int currSum = cardPoints.Take(k).Sum();
            int maxSum = currSum;
            for (int i = 1; i <= k; i++)
            {
                currSum -= cardPoints[k - i];
                currSum += cardPoints[cardPoints.Length - i];
                maxSum = Math.Max(maxSum, currSum);
            }

            return maxSum;
        }
    }
}