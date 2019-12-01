using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Find Winner on a Tic Tac Toe Game (Mine)
        /// </summary>
        /// <param name="moves"></param>
        /// <returns></returns>
        public static string Tictactoe(int[][] moves)
        {
            int[,] grid = new int[3,3];
            bool playingA = true;
            foreach (var move in moves)
            {
                grid[move[0], move[1]] = playingA ? 1 : 2;
                playingA = !playingA;
            }

            bool hasEmptyCell = false;
            for (int i = 0; i < 3; i++)
            {
                bool wonAInRow = grid[i, 0] == 1,
                    wonBInRow = grid[i, 0] == 2,
                    wonAInCol = grid[0, i] == 1,
                    wonBInCol = grid[0, i] == 2;
                for (int j = 0; j < 3; j++)
                {
                    if (j != 0 && grid[i, j] != grid[i, j - 1])
                        wonAInRow = wonBInRow = false;
                    if (j != 0 && grid[j, i] != grid[j - 1, i])
                        wonAInCol = wonBInCol = false;

                    if (grid[i, j] == 0)
                        hasEmptyCell = true;
                }

                if (wonAInRow || wonAInCol)
                    return "A";
                if (wonBInRow || wonBInCol)
                    return "B";
            }

            int mul = grid[0, 0] * grid[1, 1] * grid[2, 2];
            switch (mul)
            {
                case 1:
                    return "A";
                case 8:
                    return "B";
                default:
                    mul = grid[2, 0] * grid[1, 1] * grid[0, 2];
                    switch (mul)
                    {
                        case 1:
                            return "A";
                        case 8:
                            return "B";
                        default:
                            return hasEmptyCell ? "Pending" : "Draw";
                    }
            }
        }

        /// <summary>
        /// Number of Burgers with No Waste of Ingredients (Mine)
        /// </summary>
        /// <param name="tomatoSlices"></param>
        /// <param name="cheeseSlices"></param>
        /// <returns></returns>
        public static IList<int> NumOfBurgers(int tomatoSlices, int cheeseSlices)
        {
            int k = 4 * cheeseSlices - tomatoSlices;
            if (k >= 0 && k % 2 == 0 && cheeseSlices - k / 2 >= 0)
                return new List<int>() {cheeseSlices - k / 2, k / 2};

            return new List<int>();
        }
    }
}
