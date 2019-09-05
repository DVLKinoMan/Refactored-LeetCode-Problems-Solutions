namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Find the Town Judge (Mine)
        /// </summary>
        /// <param name="N"></param>
        /// <param name="trust"></param>
        /// <returns></returns>
        public static int FindJudge(int N, int[][] trust)
        {
            bool[,] matrix = new bool[N + 1, N + 1];
            for (int i = 0; i < trust.Length; i++)
                matrix[trust[i][0], trust[i][1]] = true;

            for (int j = 1; j <= N; j++)
            {
                bool haveAllOnesInCol = true;
                for (int i = 1; i <= N; i++)
                    if (!matrix[i, j] && i != j)
                    {
                        haveAllOnesInCol = false;
                        break;
                    }

                if (haveAllOnesInCol)
                {
                    bool haveAllZerosInRow = true;
                    for (int j1 = 1; j1 <= N; j1++)
                        if (matrix[j, j1] && j != j1)
                        {
                            haveAllZerosInRow = false;
                            break;
                        }
                    if (haveAllZerosInRow)
                        return j;
                }
            }

            return -1;
        }

        /// <summary>
        /// Find the Town Judge (Not Mine - Better)
        /// </summary>
        /// <param name="N"></param>
        /// <param name="trust"></param>
        /// <returns></returns>
        public static int FindJudge2(int N, int[][] trust)
        {
            int[] count = new int[N + 1];
            foreach (var t in trust)
            {
                count[t[0]]--;
                count[t[1]]++;
            }
            for (int i = 1; i <= N; ++i)
                if (count[i] == N - 1)
                    return i;

            return -1;
        }
    }
}
