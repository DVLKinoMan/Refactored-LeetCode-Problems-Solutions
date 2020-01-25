namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Predict the Winner (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool PredictTheWinner(int[] nums)
        {
            return SlidingWindow(0, nums.Length - 1);

            bool SlidingWindow(int sInd, int eInd, int fScore = 0, int sScore = 0, bool firstTurn = true)
            {
                if (sInd > eInd)
                    return fScore >= sScore;

                if (firstTurn)
                    return SlidingWindow(sInd + 1, eInd, fScore+nums[sInd], sScore, false) || 
                           SlidingWindow(sInd, eInd - 1, fScore+nums[eInd], sScore,false);

                return SlidingWindow(sInd + 1, eInd, fScore, sScore+nums[sInd]) &&
                       SlidingWindow(sInd, eInd - 1, fScore, sScore + nums[eInd]);
            }
        }
    }
}
